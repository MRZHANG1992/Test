package com.aote.expression.paramprocessor;

import com.aote.expression.Param;

public class NoFitValueException extends RuntimeException {

	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;

	public NoFitValueException(Param param) {
		super("����" + param.getTag() + "��û�к��ʲ���ֵ");
	}
}
