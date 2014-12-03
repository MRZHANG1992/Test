package com.aote.util;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;

/**
 * ����Tomcat����־�������ҵ���װ�ж�ʧ���û�������
 */
public final class LogParser {

	/**
	 * ���з�ʽΪ��java LogParser log�ļ���   ������   ����ļ���
     *
	 */
	public static void main(String[] args) {
		try {
			// �򿪽���ļ�
			String output = "e:\\logparse.txt";
			String fold = "e:\\logdatas";
			String key = "11005930";
			FileWriter writer = new FileWriter(output);
			BufferedWriter bw = new BufferedWriter(writer);
			//����0ΪĿ¼������Ŀ¼�е������ļ�����ѭ������
		
			File dir = new File(fold);
			
			for(File file : dir.listFiles()) {
				System.out.println("���ڴ���" + file.getName());
				processOneFile(file,key, bw);	
			}
			bw.flush();
			writer.flush();
			bw.close();
			writer.close();
			System.out.println("����End��" );

		} catch (IOException e) {
			System.out.println(e.getMessage());
		}
	}
	
	//�ж�source���Ƿ��йؼ���keys���ؼ��ְ����ŷָ���source�а���
	//���������йؼ��֣������档���򣬷���false��
	public static boolean contains(String source, String keys) {
		for(String key : keys.split(",")) {
			//ֻҪ�в������ģ��ͷ���false
			if(!source.contains(key)) {
				return false;
			}
		}
		return true;
	}
	
	//����һ����־�ļ�������־�ļ����ҵ������йؼ��ֵ��У�д��Ŀ���ļ��С�
	public static void processOneFile(File logFile, String keys, BufferedWriter bw){
		try {
			// ����־�ļ��Լ�����ļ�
			FileReader reader = new FileReader(logFile);
			BufferedReader br = new BufferedReader(reader);
			// ����־�ļ����һ��
			int i = 0;
			String str = br.readLine();
			while(str != null) {
				// �������������������һ�и�ʽ����������ļ���
				if(contains(str, keys)) {
					bw.append(i + "--" + str);
					bw.newLine();
				}
				str = br.readLine();
				i++;
			}
			br.close();
			reader.close();
		} catch (IOException e) {
			System.out.println(e.getMessage());
		}
	}
}
