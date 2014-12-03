package com.aote.helper;

import java.util.LinkedList;

/**
 * �ַ���������
 * @author Administrator
 *
 */
public class StringHelper {

	
	/**
	 * ���Ը����ַ��ָ���ַ����ֽ���ַ�������
	 */
	public static LinkedList stringToLinkedList(String source, char ch) {
		LinkedList v = new LinkedList();
		if (source == null || source.equals("")) {
			return v;
		}
		int start = 0;
		int end = source.indexOf(ch);
		while (end != -1) {
			String str = source.substring(start, end);
			v.add(str);
			start = end + 1;
			end = source.indexOf(ch, start);
		}
		String str = source.substring(start);
		v.add(str);
		return v;
	}
}
