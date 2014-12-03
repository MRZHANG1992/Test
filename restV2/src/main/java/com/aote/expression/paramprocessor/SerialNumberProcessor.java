package com.aote.expression.paramprocessor;

import java.util.HashMap;
import java.util.Map;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.orm.hibernate3.HibernateTemplate;
import com.aote.expression.Param;

/**
 * ���Ĭ��ֵ������
 * 
 */
public class SerialNumberProcessor implements ParamProcessor {
    
	@Autowired  
	private HibernateTemplate hibernateTemplate;
 
 

	//����nameȡ���ݣ� ���û�б�ţ�������ʼֵΪ1�ı��
	public String process(Param param) {
		String result ;
		Map paramData = param.getParams();
		String serialName = (String) paramData.get("name");
		String length = (String) paramData.get("length");
		
		Map obj = (Map) this.hibernateTemplate.get("serial", serialName);
		int temp;
		if (obj == null) {
			obj = new HashMap();
			obj.put("id", serialName);
			temp = 1;
		} else {
			temp = Integer.parseInt(obj.get("value") + "");
		}
		obj.put("value", temp + 1);
		this.hibernateTemplate.saveOrUpdate("serial", obj);
		//�����趨�ĳ��Ȳ���
		result = temp+"";
		if (length == null || length.equals("")) {
			return result;
		}
		// ���Ȳ�����ر��ǰ��0
		int defLength = Integer.parseInt(length);
		int numLength = result.length();
		for (int i = 0; i < (defLength - numLength); i++) {
			result = "0" + result;
		}
		return result;
	}
}
