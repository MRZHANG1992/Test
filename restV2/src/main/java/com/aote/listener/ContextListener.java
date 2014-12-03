package com.aote.listener;

import javax.servlet.ServletContext;
import javax.servlet.ServletContextEvent;
import javax.servlet.ServletContextListener;

public class ContextListener implements ServletContextListener {

	/*
	 * �����Ķ���
	 */
	private static ServletContext context;

	public void contextInitialized(ServletContextEvent arg0) {
		context = arg0.getServletContext();
	}

	/*
	 * �ṩ�����Ķ���
	 */
	public static ServletContext getContext() {
		return context;
	}

	public void contextDestroyed(ServletContextEvent arg0) {
	}

}
