package com.aote.expression;

import java.io.Reader;
import java.io.StringReader;
import java.util.HashMap;
import java.util.Iterator;
import java.util.List;
import java.util.Map;

import javax.servlet.http.HttpServletRequest;

import com.aote.expression.antlr.StringExpression;
import com.aote.expression.antlr.StringLexer;

 

 

/**
 * ���ʽֵ������ ��ҳ���в��ұ��ʽ���ò����д���
 * 
 */
public class ExpressionGenerator {

	/**
	 * ����
	 */
	private static ExpressionGenerator self = new ExpressionGenerator();

	private ExpressionGenerator() {
	}

	public static ExpressionGenerator getInstance() {
		return self;
	}

	/**
	 * �������ʽ
	 */
	public static Object getExpressionValue(String exp) {
		try {
			Object result = null;
			Reader r = new StringReader(exp);
		    StringLexer lexer = new StringLexer(r);
			StringExpression parser = new StringExpression(lexer);
			parser.setLexer(lexer);
			result = parser.expression();
			return result;
		} catch (RuntimeException e) {
			throw e;
		} catch (Exception e) {
			throw new RuntimeException(e);
		}
	}

 
}