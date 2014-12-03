package com.aote.rs;

import java.util.Collection;
import java.util.Date;
import java.util.Enumeration;
import java.util.HashMap;
import java.util.Hashtable;
import java.util.Iterator;
import java.util.LinkedList;
import java.util.Map;

import javax.ws.rs.GET;
import javax.ws.rs.POST;
import javax.ws.rs.Path;
import javax.ws.rs.PathParam;
import javax.ws.rs.WebApplicationException;

import net.sf.json.JSONArray;
import net.sf.json.JSONObject;

import org.apache.log4j.Logger;

import com.browsesoft.Entity;
import com.browsesoft.EntityManager;
import com.browsesoft.dbtools.DBTools;
import com.browsesoft.resource.BasicResource;
import com.browsesoft.resource.LicensePolicyTool;
import com.browsesoft.user.User;

@Path("user")
public class UserService {
	static Logger log = Logger.getLogger(UserService.class);

	@GET
	@Path("systime")
	public String getTime() {
		long time = new Date().getTime();
		return "" + time;
	}

	@GET
	@Path("{username}")
	public String getUser(@PathParam("username") String name) {
		try {
			User user = (User) EntityManager.getInstance().getUserForLoginName(
					name);
			String result = getUserString(user);
			log.debug(result);
			return result;
		} catch (Exception e) {
			throw new WebApplicationException(e);
		}
	}

	@GET
	@Path("{username}/{password}")
	// �����û��������ȡ�û���Ϣ
	public String getUserWithPass(@PathParam("username") String name,
			@PathParam("password") String password) {
		try {
			User user = (User) EntityManager.getInstance().getUserForLoginName(
					name);
			String userpass = (String) user.attributes.get("password");
			log.debug("ϵͳ�еǼǵ��û�����: " + userpass);
			// ���벻ͬ���׳���������쳣
			if (!password.equals(userpass)) {
				throw new WebApplicationException(401);
			}
			String result = getUserString(user);
			log.debug(result);
			return result;
		} catch (WebApplicationException e) {
			throw e;
		} catch (Exception e) {
			throw new WebApplicationException(e);
		}
	}

	@GET
	@Path("{username}/{password}/{module}")
	// ��ȡĳ����¼�û���ָ��ģ�������
	public String getUserWithPass(@PathParam("username") String name,
			@PathParam("password") String password,
			@PathParam("module") String module) {
		try {

			User user = (User) EntityManager.getInstance().getUser(name,
					password, isCase());
			// ���벻ͬ���׳���������쳣
			if (user == null) {
				throw new WebApplicationException(401);
			}
			//����û�Ϊ������ʹ�ã�����401
			String f_using = (String) user.getAttributes().get("f_using");
			if(f_using !=null && f_using.equals("��"))
			{
				throw new WebApplicationException(401);
			}
			String result = getUserString(user, module);
			log.debug(result);
			return result;
		} catch (WebApplicationException e) {
			throw e;
		} catch (Exception e) {
			throw new WebApplicationException(e);
		}
	}

	@GET
	@Path("/{module}")
	// ��ȡĳ����¼�û���ָ��ģ�������
	public String getUserWithPass(@PathParam("module") String module) {
		try {
			User  user = (User) request.getSession().getAttribute("loginUser");
			String result = getUserString(user, module);
			log.debug(result);
			return result;
		} catch (WebApplicationException e) {
			throw e;
		} catch (Exception e) {
			throw new WebApplicationException(e);
		}
	}

	@POST
	@Path("/entity")
	public String save(String data) {
		log.debug(data);
		try {
			// �������ݣ�����id�õ����󣬸�������
			JSONArray array = JSONArray.fromObject(data);
			JSONObject obj = (JSONObject) array.iterator().next();
			JSONObject dataObj = obj.getJSONObject("data");
			Hashtable newAttrs = this.jsonToHash(dataObj);
			String id = (String) newAttrs.get("id");
			Entity entity = (Entity) EntityManager.getInstance().getObject(id);
			if (entity == null) {
				throw new WebApplicationException(500);
			}
			entity.getAttributes().putAll(newAttrs);
			entity.update();
			return obj.toString();
		} catch (Exception e) {
			throw new WebApplicationException(500);
		}
	}
	
	@POST
	@Path("/entityMemUpdate")
	public String saveMem(String data) {
		log.debug(data);
		try {
			// �������ݣ�����id�õ����󣬸�������
			JSONArray array = JSONArray.fromObject(data);
			JSONObject obj = (JSONObject) array.iterator().next();
			JSONObject dataObj = obj.getJSONObject("data");
			Hashtable newAttrs = this.jsonToHash(dataObj);
			String id = (String) newAttrs.get("id");
			Entity entity = (Entity) EntityManager.getInstance().getObject(id);
			if (entity == null) {
				throw new WebApplicationException(500);
			}
			entity.getAttributes().putAll(newAttrs);
		//	entity.update();
			return obj.toString();
		} catch (Exception e) {
			throw new WebApplicationException(500);
		}
	}


	/**
	 * json����תmap
	 */
	private Hashtable jsonToHash(JSONObject obj) {
		Hashtable result = new Hashtable();
		Iterator iter = obj.keySet().iterator();
		while (iter.hasNext()) {
			String key = iter.next().toString();
			String value = obj.getString(key);
			if (value != null & !value.equals("null")) {
				key = key.toLowerCase();
				result.put(key, value);
			}
		}
		return result;
	}

	/**
	 * ���Ƿ����ִ�Сд
	 * 
	 * @param match
	 * @return
	 */
	private boolean isCase() {
		try {
			// ȡ�����õ��Ƿ����ִ�Сд����
			String sql = "select f_matchcase from t_setpassrule";
			String[][] temp = DBTools.executeQueryWithTableHead(sql);
			return temp[1][0].equals("���ִ�Сд");
		} catch (Exception ex) {
			return false;
		}
	}

	// ��ȡ�û���Ϣ��ֻ��ȡָ��ģ�����Ϣ
	public String getUserString(User user, String module) {
		// ����û�Ȩ�ޣ������û�������
		Collection rs = LicensePolicyTool.getRights(user, "function");
		// �Ի�õ�Ȩ�޽��д���ȥ������ϵ�������ӹ�ϵ���Ա�Jsonת���������б������ϲ�ĸ�
		Map<String, Object> root = null;
		for (BasicResource func : getRoot(rs)) {
			// ��������ģ��������ͬ
			if (func.attributes.get("name").equals(module)) {
				root = getMap(func, rs);
				break;
			}
		}
		if (root == null) {
			throw new WebApplicationException(500);
		}
		// �Ӹ�Ԫ����
		Map<String, Object> map = new HashMap<String, Object>(user.attributes);
		map.put("functions", root.get("children"));
		// ѭ�����ø�����
		BasicResource parent = (BasicResource) user.getParent();
		Map ht = map;
		while (parent != null) {
			Map parentMap = getMap(parent.attributes);
			ht.put("parent", parentMap);
			ht = parentMap;
			parent = (BasicResource) parent.getParent();
		}
		String result = JSONObject.fromObject(map).toString();
		return result;
	}

	// ��ȡ��Դ��һ�����ԣ������������ϵ����
	private Map getMap(Hashtable attrs) {
		Map result = new HashMap();
		Enumeration en = attrs.keys();
		while (en.hasMoreElements()) {
			Object key = en.nextElement();
			Object value = attrs.get(key);
			if (value.getClass().isPrimitive() || value instanceof String) {
				result.put(key, value);
			}
		}
		return result;
	}

	// ��ȡ�û���Ϣ
	public String getUserString(User user) {
		// ����û�Ȩ�ޣ������û�������
		Collection rs = LicensePolicyTool.getRights(user, "function");
		// �Ի�õ�Ȩ�޽��д���ȥ������ϵ�������ӹ�ϵ���Ա�Jsonת���������б������ϲ�ĸ�
		LinkedList funcs = new LinkedList();
		for (BasicResource func : getRoot(rs)) {
			funcs.add(getMap(func, rs));
		}
		Map<String, Object> map = new HashMap<String, Object>(user.attributes);
		map.put("functions", funcs);
		String result = JSONObject.fromObject(map).toString();
		return result;
	}

	// ��õ�һ�㹦���б�
	public LinkedList<BasicResource> getRoot(Collection rs) {
		LinkedList<BasicResource> result = new LinkedList<BasicResource>();
		for (Object obj : rs) {
			BasicResource func = (BasicResource) obj;
			// ��������������У����Ǹ�
			if (!rs.contains(func.getParent())) {
				result.add(func);
			}
		}
		return result;
	}

	// ����һ�������������ӵ��Լ����������У����Ұ�������ɾ������Ҫ�ݹ����
	public Map<String, Object> getMap(BasicResource func, Collection rs) {
		Map<String, Object> result = new HashMap<String, Object>(
				func.attributes);
		// ��øù�������Ȩ���ʵ���
		LinkedList list = new LinkedList(func.getChildrenByType("function"));
		list.retainAll(rs);
		// ֻ�����Ե����б�
		LinkedList attrList = new LinkedList();
		for (Object obj : list) {
			BasicResource f = (BasicResource) obj;
			Map<String, Object> child = getMap(f, rs);
			attrList.add(child);
		}
		// ������
		if (!attrList.isEmpty()) {
			result.put("children", attrList);
		}
		return result;
	}
}
