package com.aote.expression.paramprocessor;

 

import com.aote.expression.Param;

/**
 * ����������
 * 
 */
public interface ParamProcessor {

	/**
	 * ���ݲ��������Լ��Ͻ���Ĭ��ֵ����
	 * 
	 * @param attribures
	 *            ���Լ���
	 * @param param
	 *            ����
	 * @param loginUser
	 *            ��¼�û�
	 * @return
	 */
	public String process(Param param) throws NoFitValueException;
}
