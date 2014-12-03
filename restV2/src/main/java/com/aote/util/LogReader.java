package com.aote.util;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;

public class LogReader {
	// ��һ�������־�ļ����ȡ����������������ļ���
	public static void main(String[] args) {
		try {
			// �򿪽���ļ�
			FileWriter writer = new FileWriter(args[2]);
			BufferedWriter bw = new BufferedWriter(writer);
			FileReader reader = new FileReader(args[0]);
			BufferedReader br = new BufferedReader(reader);
			// ��ÿ�ʼ�У��Լ�������
			String[] nums = args[1].split(",");
			int start = Integer.parseInt(nums[0]);
			int len = Integer.parseInt(nums[1]);
			// ������ʼ��
			for(int i = 0; i < start; i++) {
				br.readLine();
			}
			// ��ȡ���ݣ��ŵ�Ŀ���ļ���
			for(int i = 0; i < len; i++) {
				String str = br.readLine();
				bw.append(str);
				bw.newLine();
			}
			br.close();
			reader.close();
			bw.flush();
			writer.flush();
			bw.close();
			writer.close();
		} catch (IOException e) {
			System.out.println(e.getMessage());
		}
	}
}
