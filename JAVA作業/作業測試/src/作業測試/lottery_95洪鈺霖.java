package �@�~����;
import java.awt.BorderLayout;
import java.awt.EventQueue;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.EmptyBorder;

import javax.swing.JButton;
import java.awt.Color;
import java.awt.Font;
import java.awt.event.ActionListener;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Timer;
import java.util.TimerTask;
import java.awt.event.ActionEvent;
import java.awt.GridBagLayout;
import java.awt.GridBagConstraints;
import java.awt.Insets;
import javax.swing.JTextField;
import java.awt.Dimension;
import java.awt.FlowLayout;
import javax.swing.GroupLayout;
import javax.swing.GroupLayout.Alignment;
import javax.swing.border.CompoundBorder;
import javax.swing.border.BevelBorder;
import java.awt.Rectangle;
import javax.swing.JLabel;
import javax.swing.*;

public class lottery_95�x��M extends JFrame {

	private JPanel contentPane;
	private JLabel lbl�}�����X;
	private JTextField tex_�}��1;
	private JLabel lbl��ܪ����X;
	private static JTextField tex_���a1 = new JTextField();
	private JTextField tex_�}��2;
	private JTextField tex_�}��3;
	private JTextField tex_�}��4;
	private JTextField tex_�}��5;
	private JTextField tex_�}��6;
	private JTextField tex_�S�O��;
	private static JTextField tex_���a2 = new JTextField();
	private static JTextField tex_���a3 = new JTextField();
	private static JTextField tex_���a4 = new JTextField();
	private static JTextField tex_���a5 = new JTextField();
	private static JTextField tex_���a6 = new JTextField();
	private static JTextField[] TB_user = { tex_���a1, tex_���a2, tex_���a3, tex_���a4, tex_���a5, tex_���a6 };
	private JLabel label_2;
	private JLabel lbl�S�O��;
	static JButton[] btn_num = new JButton[49];
	private boolean priceStaus = false;
    static  ArrayList<Integer> userList = new ArrayList<Integer>();
    
    int count = 0;
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					lottery_95�x��M frame = new lottery_95�x��M();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	
	    
	public lottery_95�x��M() {
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setBounds(100, 100, 755, 462);
		contentPane = new JPanel();
		contentPane.setBorder(new EmptyBorder(5, 5, 5, 5));
		contentPane.setLayout(new BorderLayout(0, 0));
		setContentPane(contentPane);
		
		JPanel panel = new JPanel();
		panel.setBorder(new EmptyBorder(5, 30, 5, 30));
		panel.setBackground(new Color(245, 222, 179));
		panel.setPreferredSize(new Dimension(10, 100));
		contentPane.add(panel, BorderLayout.NORTH);
		GridBagLayout gbl_panel = new GridBagLayout();
		gbl_panel.columnWidths = new int[]{0, 40, 44, 42, 38, 42, 39, 0, 49, 59, 0, 0, 0};
		gbl_panel.rowHeights = new int[]{0, 0, 0, 0};
		gbl_panel.columnWeights = new double[]{0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, Double.MIN_VALUE};
		gbl_panel.rowWeights = new double[]{0.0, 0.0, 0.0, Double.MIN_VALUE};
		panel.setLayout(gbl_panel);
		
		label_2 = new JLabel("~\u6B61\u8FCE\u4F86\u5230\u5927\u6A02\u900F\u6A21\u64EC\u5668~");
		label_2.setForeground(new Color(255, 0, 255));
		label_2.setFont(new Font("�L�n������", Font.BOLD, 20));
		label_2.setBackground(new Color(221, 160, 221));
		GridBagConstraints gbc_label_2 = new GridBagConstraints();
		gbc_label_2.gridwidth = 4;
		gbc_label_2.insets = new Insets(0, 0, 5, 5);
		gbc_label_2.gridx = 5;
		gbc_label_2.gridy = 0;
		panel.add(label_2, gbc_label_2);
		
		lbl�}�����X = new JLabel("\u958B\u734E\u865F\u78BC:");
		lbl�}�����X.setBackground(new Color(221, 160, 221));
		lbl�}�����X.setFont(new Font("�L�n������", Font.BOLD, 16));
		GridBagConstraints gbc_lbl�}�����X = new GridBagConstraints();
		gbc_lbl�}�����X.insets = new Insets(0, 0, 5, 5);
		gbc_lbl�}�����X.anchor = GridBagConstraints.EAST;
		gbc_lbl�}�����X.gridx = 0;
		gbc_lbl�}�����X.gridy = 1;
		panel.add(lbl�}�����X, gbc_lbl�}�����X);
		
		tex_�}��1 = new JTextField();
		tex_�}��1.setAlignmentY(0.0f);
		tex_�}��1.setAlignmentX(0.0f);
		GridBagConstraints gbc_tex_�}��1 = new GridBagConstraints();
		gbc_tex_�}��1.insets = new Insets(0, 0, 5, 5);
		gbc_tex_�}��1.fill = GridBagConstraints.BOTH;
		gbc_tex_�}��1.gridx = 1;
		gbc_tex_�}��1.gridy = 1;
		panel.add(tex_�}��1, gbc_tex_�}��1);
		tex_�}��1.setColumns(3);
		
		tex_�}��2 = new JTextField();
		tex_�}��2.setColumns(3);
		tex_�}��2.setAlignmentY(0.0f);
		tex_�}��2.setAlignmentX(0.0f);
		GridBagConstraints gbc_tex_�}��2 = new GridBagConstraints();
		gbc_tex_�}��2.insets = new Insets(0, 0, 5, 5);
		gbc_tex_�}��2.fill = GridBagConstraints.HORIZONTAL;
		gbc_tex_�}��2.gridx = 2;
		gbc_tex_�}��2.gridy = 1;
		panel.add(tex_�}��2, gbc_tex_�}��2);
		
		tex_�}��3 = new JTextField();
		tex_�}��3.setColumns(3);
		tex_�}��3.setAlignmentY(0.0f);
		tex_�}��3.setAlignmentX(0.0f);
		GridBagConstraints gbc_tex_�}��3 = new GridBagConstraints();
		gbc_tex_�}��3.insets = new Insets(0, 0, 5, 5);
		gbc_tex_�}��3.fill = GridBagConstraints.HORIZONTAL;
		gbc_tex_�}��3.gridx = 3;
		gbc_tex_�}��3.gridy = 1;
		panel.add(tex_�}��3, gbc_tex_�}��3);
		
		tex_�}��4 = new JTextField();
		tex_�}��4.setColumns(3);
		tex_�}��4.setAlignmentY(0.0f);
		tex_�}��4.setAlignmentX(0.0f);
		GridBagConstraints gbc_tex_�}��4 = new GridBagConstraints();
		gbc_tex_�}��4.insets = new Insets(0, 0, 5, 5);
		gbc_tex_�}��4.fill = GridBagConstraints.HORIZONTAL;
		gbc_tex_�}��4.gridx = 4;
		gbc_tex_�}��4.gridy = 1;
		panel.add(tex_�}��4, gbc_tex_�}��4);
		
		tex_�}��5 = new JTextField();
		tex_�}��5.setColumns(3);
		tex_�}��5.setAlignmentY(0.0f);
		tex_�}��5.setAlignmentX(0.0f);
		GridBagConstraints gbc_tex_�}��5 = new GridBagConstraints();
		gbc_tex_�}��5.insets = new Insets(0, 0, 5, 5);
		gbc_tex_�}��5.fill = GridBagConstraints.HORIZONTAL;
		gbc_tex_�}��5.gridx = 5;
		gbc_tex_�}��5.gridy = 1;
		panel.add(tex_�}��5, gbc_tex_�}��5);
		
		tex_�}��6 = new JTextField();
		tex_�}��6.setColumns(3);
		tex_�}��6.setAlignmentY(0.0f);
		tex_�}��6.setAlignmentX(0.0f);
		GridBagConstraints gbc_tex_�}��6 = new GridBagConstraints();
		gbc_tex_�}��6.insets = new Insets(0, 0, 5, 5);
		gbc_tex_�}��6.fill = GridBagConstraints.HORIZONTAL;
		gbc_tex_�}��6.gridx = 6;
		gbc_tex_�}��6.gridy = 1;
		panel.add(tex_�}��6, gbc_tex_�}��6);
		
		lbl�S�O�� = new JLabel("\u7279\u5225\u865F\u78BC:");
		lbl�S�O��.setFont(new Font("�L�n������", Font.BOLD, 16));
		lbl�S�O��.setBackground(new Color(221, 160, 221));
		GridBagConstraints gbc_lbl�S�O�� = new GridBagConstraints();
		gbc_lbl�S�O��.insets = new Insets(0, 0, 5, 5);
		gbc_lbl�S�O��.anchor = GridBagConstraints.EAST;
		gbc_lbl�S�O��.gridx = 7;
		gbc_lbl�S�O��.gridy = 1;
		panel.add(lbl�S�O��, gbc_lbl�S�O��);
		
		tex_�S�O�� = new JTextField();
		tex_�S�O��.setColumns(3);
		tex_�S�O��.setAlignmentY(0.0f);
		tex_�S�O��.setAlignmentX(0.0f);
		GridBagConstraints gbc_tex_�S�O�� = new GridBagConstraints();
		gbc_tex_�S�O��.insets = new Insets(0, 0, 5, 5);
		gbc_tex_�S�O��.fill = GridBagConstraints.HORIZONTAL;
		gbc_tex_�S�O��.gridx = 8;
		gbc_tex_�S�O��.gridy = 1;
		panel.add(tex_�S�O��, gbc_tex_�S�O��);
		
		lbl��ܪ����X = new JLabel("\u60A8\u9078\u64C7\u7684\u865F\u78BC:");
		lbl��ܪ����X.setFont(new Font("�L�n������", Font.BOLD, 16));
		lbl��ܪ����X.setBackground(new Color(221, 160, 221));
		GridBagConstraints gbc_lbl��ܪ����X = new GridBagConstraints();
		gbc_lbl��ܪ����X.anchor = GridBagConstraints.EAST;
		gbc_lbl��ܪ����X.insets = new Insets(0, 0, 0, 5);
		gbc_lbl��ܪ����X.gridx = 0;
		gbc_lbl��ܪ����X.gridy = 2;
		panel.add(lbl��ܪ����X, gbc_lbl��ܪ����X);
		
		
		tex_���a1.setColumns(3);
		tex_���a1.setAlignmentY(0.0f);
		tex_���a1.setAlignmentX(0.0f);
		GridBagConstraints gbc_tex_���a1 = new GridBagConstraints();
		gbc_tex_���a1.insets = new Insets(0, 0, 0, 5);
		gbc_tex_���a1.fill = GridBagConstraints.HORIZONTAL;
		gbc_tex_���a1.gridx = 1;
		gbc_tex_���a1.gridy = 2;
		panel.add(tex_���a1, gbc_tex_���a1);
		
		
		tex_���a2.setColumns(3);
		tex_���a2.setAlignmentY(0.0f);
		tex_���a2.setAlignmentX(0.0f);
		GridBagConstraints gbc_tex_���a2 = new GridBagConstraints();
		gbc_tex_���a2.insets = new Insets(0, 0, 0, 5);
		gbc_tex_���a2.fill = GridBagConstraints.HORIZONTAL;
		gbc_tex_���a2.gridx = 2;
		gbc_tex_���a2.gridy = 2;
		panel.add(tex_���a2, gbc_tex_���a2);
		
		
		tex_���a3.setColumns(3);
		tex_���a3.setAlignmentY(0.0f);
		tex_���a3.setAlignmentX(0.0f);
		GridBagConstraints gbc_tex_���a3 = new GridBagConstraints();
		gbc_tex_���a3.insets = new Insets(0, 0, 0, 5);
		gbc_tex_���a3.fill = GridBagConstraints.HORIZONTAL;
		gbc_tex_���a3.gridx = 3;
		gbc_tex_���a3.gridy = 2;
		panel.add(tex_���a3, gbc_tex_���a3);
		
		
		tex_���a4.setColumns(3);
		tex_���a4.setAlignmentY(0.0f);
		tex_���a4.setAlignmentX(0.0f);
		GridBagConstraints gbc_tex_���a4 = new GridBagConstraints();
		gbc_tex_���a4.insets = new Insets(0, 0, 0, 5);
		gbc_tex_���a4.fill = GridBagConstraints.HORIZONTAL;
		gbc_tex_���a4.gridx = 4;
		gbc_tex_���a4.gridy = 2;
		panel.add(tex_���a4, gbc_tex_���a4);
		
		
		tex_���a5.setColumns(3);
		tex_���a5.setAlignmentY(0.0f);
		tex_���a5.setAlignmentX(0.0f);
		GridBagConstraints gbc_tex_���a5 = new GridBagConstraints();
		gbc_tex_���a5.insets = new Insets(0, 0, 0, 5);
		gbc_tex_���a5.fill = GridBagConstraints.HORIZONTAL;
		gbc_tex_���a5.gridx = 5;
		gbc_tex_���a5.gridy = 2;
		panel.add(tex_���a5, gbc_tex_���a5);
		
		
		tex_���a6.setColumns(3);
		tex_���a6.setAlignmentY(0.0f);
		tex_���a6.setAlignmentX(0.0f);
		GridBagConstraints gbc_tex_���a6 = new GridBagConstraints();
		gbc_tex_���a6.insets = new Insets(0, 0, 0, 5);
		gbc_tex_���a6.fill = GridBagConstraints.HORIZONTAL;
		gbc_tex_���a6.gridx = 6;
		gbc_tex_���a6.gridy = 2;
		panel.add(tex_���a6, gbc_tex_���a6);
		
		JButton btn�}�� = new JButton("\u958B\u734E");
		btn�}��.addActionListener(new ActionListener()
	    {
	      public void actionPerformed(ActionEvent arg0)
	      {
	    	  lottery_95�x��M.this.choosenum();
	    	  lottery_95�x��M.this.priceStaus = true;
	      }
	    });
		GridBagConstraints gbc_btn�}�� = new GridBagConstraints();
		gbc_btn�}��.insets = new Insets(0, 0, 0, 5);
		gbc_btn�}��.gridx = 7;
		gbc_btn�}��.gridy = 2;
		panel.add(btn�}��, gbc_btn�}��);
		btn�}��.setFont(new Font("�L�n������", Font.BOLD, 18));
		btn�}��.setBounds(new Rectangle(10, 10, 15, 15));
		btn�}��.setBorder(new CompoundBorder(new BevelBorder(BevelBorder.RAISED, null, null, null, null), new EmptyBorder(3, 8, 3, 8)));
		btn�}��.setBackground(new Color(255, 255, 0));
		
				
				JButton btn�︹ = new JButton("\u81EA\u52D5\u9078\u865F");
				btn�︹.addActionListener(new ActionListener()
	    {
	      public void actionPerformed(ActionEvent arg0)
	      {
	    	  lottery_95�x��M.this.clearTB();
	          final lottery_95�x��M.MyThread flash1 = new lottery_95�x��M.MyThread(6);
	        flash1.start();
	        new Thread()
	        {
	          public void run()
	          {
	            try
	            {
	              Thread.sleep(1000L);
	              flash1.stoptimer();
	              lottery_95�x��M.this.buttonClear();
	              lottery_95�x��M.this.com2();
	            }
	            catch (InterruptedException e)
	            {
	              e.printStackTrace();
	            }
	          }
	        }.start();
	        lottery_95�x��M.this.clearPriceTB();
	      }
	    });		
				GridBagConstraints gbc_btn�︹ = new GridBagConstraints();
				gbc_btn�︹.insets = new Insets(0, 0, 0, 5);
				gbc_btn�︹.gridx = 8;
				gbc_btn�︹.gridy = 2;
				panel.add(btn�︹, gbc_btn�︹);
				btn�︹.setFont(new Font("�L�n������", Font.BOLD, 18));
				btn�︹.setBounds(new Rectangle(10, 10, 6, 6));
				btn�︹.setBorder(new CompoundBorder(new BevelBorder(BevelBorder.RAISED, null, null, null, null), new EmptyBorder(3, 8, 3, 8)));
				btn�︹.setBackground(new Color(106, 90, 205));
		
				
				
				JButton btn�M�� = new JButton("\u6E05\u9664\u9078\u865F");
				btn�M��.addActionListener
				(new ActionListener()
	    {
	      public void actionPerformed(ActionEvent arg0)
	      {
	    	  lottery_95�x��M.this.clearTB();
	    	  lottery_95�x��M.this.clearPriceTB();
	    	  lottery_95�x��M.this.buttonClear();
	    	  lottery_95�x��M.this.userList.removeAll(lottery_95�x��M.userList);
	    	  
	      }
	    });
				GridBagConstraints gbc_btn�M�� = new GridBagConstraints();
				gbc_btn�M��.insets = new Insets(0, 0, 0, 5);
				gbc_btn�M��.fill = GridBagConstraints.HORIZONTAL;
				gbc_btn�M��.gridx = 9;
				gbc_btn�M��.gridy = 2;
				panel.add(btn�M��, gbc_btn�M��);
				btn�M��.setFont(new Font("�L�n������", Font.BOLD, 18));
				btn�M��.setBorder(new CompoundBorder(new BevelBorder(BevelBorder.RAISED, null, null, null, null), new EmptyBorder(3, 8, 3, 8)));
				btn�M��.setBackground(new Color(255, 0, 0));
				btn�M��.setAlignmentX(10.0f);
				btn�M��.setSelected(true);
		JPanel panel_1 = new JPanel();
		panel_1.setBackground(new Color(0, 255, 255));
		
		contentPane.add(panel_1, BorderLayout.CENTER);
		
		
		
		
		GroupLayout gl_panel_1 = new GroupLayout(panel_1);
		gl_panel_1.setHorizontalGroup(
			gl_panel_1.createParallelGroup(Alignment.TRAILING)
				.addGap(0, 717, Short.MAX_VALUE)
		);
		gl_panel_1.setVerticalGroup(
			gl_panel_1.createParallelGroup(Alignment.TRAILING)
				.addGap(0, 490, Short.MAX_VALUE)
		);
		panel_1.setLayout(gl_panel_1);
		btn_num = new JButton[49];	    
	    panel_1.setPreferredSize(new Dimension(10, 15));

	    panel_1.setBorder(new EmptyBorder(20, 20, 20, 20));
	    panel_1.setLayout(new FlowLayout(10, 10, 10));
	    for (int i = 0; i < 49; i++)
	    {
	      btn_num[i] = new JButton(String.format("%02d", new Object[] { Integer.valueOf(i + 1) }));
	      btn_num[i].setPreferredSize(new Dimension(50, 50));
	      btn_num[i].setBackground(new Color(250, 192, 192));
	      btn_num[i].setFont(new Font("�L�n������", 1, 14));
	      btn_num[i].setSelected(false);
	      panel_1.add(btn_num[i]);
	      
	      btn_num[i].addActionListener(new lottery_95�x��M.buttonActionListener());
	     }
		

	  }
	
	
	class buttonActionListener
    implements ActionListener
    {
		buttonActionListener() {}
		 public void actionPerformed(ActionEvent e)
		    {
			 if(lottery_95�x��M.this.priceStaus)
			 {
				 
				 lottery_95�x��M.this.clearTB();
				 lottery_95�x��M.this.clearPriceTB();
				 lottery_95�x��M.this.buttonClear();
				 lottery_95�x��M.userList.removeAll(lottery_95�x��M.userList);
				 lottery_95�x��M.this.priceStaus = false;
			      
			 }

		      if (lottery_95�x��M.this.count < 6) {
		        for (int j = 0; j < 49; j++) {
		          if (e.getSource() == lottery_95�x��M.btn_num[j]) {
		            if (lottery_95�x��M.btn_num[j].isSelected())
		            {
		            	lottery_95�x��M.btn_num[j].setSelected(false);
		            	lottery_95�x��M.btn_num[j].setBackground(new Color(250, 192, 192));
		              
		            	lottery_95�x��M.userList.remove(Integer.valueOf(Integer.parseInt(lottery_95�x��M.btn_num[j].getText())));
		              lottery_95�x��M.this.count -= 1;
		            }
		            else
		            {
		            	lottery_95�x��M.btn_num[j].setSelected(true);
		            	lottery_95�x��M.btn_num[j].setBackground(new Color(255, 50, 50));
		              
		            	lottery_95�x��M.userList.add(Integer.valueOf(Integer.parseInt(lottery_95�x��M.btn_num[j].getText())));
		            	lottery_95�x��M.this.count += 1;
		            }
		          }
		        }
		      } else {
		        for (int j = 0; j < 49; j++) {
		          if (e.getSource() == lottery_95�x��M.btn_num[j]) {
		            if (lottery_95�x��M.btn_num[j].isSelected())
		            {
		            	lottery_95�x��M.btn_num[j].setSelected(false);
		            	lottery_95�x��M.btn_num[j].setBackground(new Color(250, 192, 192));
		            	lottery_95�x��M.userList.remove(Integer.valueOf(lottery_95�x��M.btn_num[j].getText()));
		            	lottery_95�x��M.this.count -= 1;
		            }
		            else
		            {
		              JOptionPane.showMessageDialog(null, "�z�w�g��F6�ӼƦr");
		            }
		          }
		        }
		      }
		      Collections.sort(lottery_95�x��M.userList);
		      lottery_95�x��M.this.printNum(lottery_95�x��M.userList);
		    
		    }
    }
	
	
	 private void printNum(ArrayList userList)
	  {
	    clearTB();
	    System.out.println(userList.size());
	    for (int i = 0; i < userList.size(); i++) {
	      TB_user[i].setText(String.format("%02d", new Object[] { userList.get(i) }));
	      
	    }
	    
	  }
	
	
	private void buttonClear()
	  {
	    for (int j = 0; j < 49; j++)
	    {
	      btn_num[j].setSelected(false);
	      btn_num[j].setBackground(new Color(250, 192, 192));
	      userList.remove(btn_num[j].getText());
	    }
	    this.count = 0;
	  }
	 private void clearTB()
	  {
	    for (int q = 0; q < TB_user.length; q++) {
	      TB_user[q].setText("");
	    }
	  }
	 
	 
	 private void clearPriceTB()
	  {
	    this.tex_�}��1.setText("");
	    this.tex_�}��2.setText("");
	    this.tex_�}��3.setText("");
	    this.tex_�}��4.setText("");
	    this.tex_�}��5.setText("");
	    this.tex_�}��6.setText("");
	    this.tex_�S�O��.setText("");
	  }
	 
	 
//	 
	 
	 
	 
	 private ArrayList computerRandom2()
	  {
	    ArrayList<Integer> RandomSeven = new ArrayList<Integer>();
	    
	    int[] Arytemp = new int[49];
	    for (int j = 0; j <= 48; j++) {
	      Arytemp[j] = (j + 1);
	    }
	    for (int i = 0; i < 7; i++)
	    {
	      int temp = (int)(Math.random() * 49.0D) + 1;
	      if (Arytemp[(temp - 1)] == 0)
	      {
	        i--;
	      }
	      else
	      {
	        RandomSeven.add(Integer.valueOf(temp));
	        Arytemp[(temp - 1)] = 0;
	        if (i == 6) {
	          btn_num[(temp - 1)].setBackground(new Color(255, 50, 0));
	        } else {
	          btn_num[(temp - 1)].setBackground(new Color(50, 250, 100));
	        }
	      }
	    }
	    this.tex_�S�O��.setText(String.format("%02d", new Object[] { RandomSeven.get(6) }));
	    RandomSeven.remove(6);
	    
	    Collections.sort(RandomSeven);
	    this.tex_�}��1.setText(String.format("%02d", new Object[] { RandomSeven.get(0) }));
	    this.tex_�}��2.setText(String.format("%02d", new Object[] { RandomSeven.get(1) }));
	    this.tex_�}��3.setText(String.format("%02d", new Object[] { RandomSeven.get(2) }));
	    this.tex_�}��4.setText(String.format("%02d", new Object[] { RandomSeven.get(3) }));
	    this.tex_�}��5.setText(String.format("%02d", new Object[] { RandomSeven.get(4) }));
	    this.tex_�}��6.setText(String.format("%02d", new Object[] { RandomSeven.get(5) }));
	    RandomSeven.add(Integer.valueOf(Integer.parseInt(this.tex_�S�O��.getText())));
	    System.out.println(RandomSeven);
	    return RandomSeven;
	  }
	 
	 
	 
	 private ArrayList com2()
	  {
	    clearTB();
	    for (int j = 0; j < 49; j++)
	    {
	      btn_num[j].setSelected(false);
	      btn_num[j].setBackground(new Color(100, 100, 100));
	    }
	    userList.removeAll(userList);
	    this.count = 0;
	    final int[] Arytemp = new int[49];
	    for (int j = 0; j <= 48; j++) {
	      Arytemp[j] = (j + 1);
	    }
	    new Thread()
	    {
	      public void run()
	      {
	        for (int i = 0; i < 6; i++)
	        {
	          int temp = (int)(Math.random() * 49.0D) + 1;
	          if (Arytemp[(temp - 1)] == 0)
	          {
	            i--;
	          }
	          else
	          {
	        	  lottery_95�x��M.userList.add(Integer.valueOf(temp));
	            Arytemp[(temp - 1)] = 0;
	            lottery_95�x��M.btn_num[(temp - 1)].setSelected(true);
	            lottery_95�x��M.btn_num[(temp - 1)].setBackground(new Color(255, 160, 122));
	            lottery_95�x��M.this.count += 1;
	            lottery_95�x��M.TB_user[i].setText(String.format("%02d", new Object[] {lottery_95�x��M.userList.get(i) }));
	          }
	          try
	          {
	            Thread.sleep(100L);
	          }
	          catch (InterruptedException e)
	          {
	            e.printStackTrace();
	          }
	        }
	        Collections.sort(lottery_95�x��M.userList);
	        for (int i = 0; i < lottery_95�x��M.userList.size(); i++) {
	        	lottery_95�x��M.TB_user[i].setText(String.format("%02d", new Object[] { lottery_95�x��M.userList.get(i) }));
	        }
	        System.out.printf("%s",userList);
	      }
	    }.start();
	    return userList;
	    
	  }
	 
	 
	 
	 class MyThread
	    extends Thread
	  {
	    Timer timer1 = new Timer();
	    int Max;
	    
	    public MyThread(int Max)
	    {
	      this.Max = Max;
	    }
	    
	    public void run()
	    {
	      this.timer1.schedule(new lottery_95�x��M.DateTask(this.Max), 0L, 100L);
	    }
	    
	    public void stoptimer()
	    {
	      this.timer1.cancel();
	    }
	  }
	 
	 
	 
	 class DateTask
	    extends TimerTask
	  {
	    int Max;
	    
	    public DateTask(int max)
	    {
	      this.Max = max;
	    }
	    
	    public void run()
	    {
	      for (int j = 0; j < 49; j++)
	      {
	    	  lottery_95�x��M.btn_num[j].setSelected(false);
	    	  lottery_95�x��M.btn_num[j].setBackground(new Color(50, 50, 192));
	      }
	      int[] Arytemp = new int[49];
	      for (int j = 0; j <= 48; j++) {
	        Arytemp[j] = (j + 1);
	      }
	      for (int i = 0; i < this.Max; i++)
	      {
	        int temp = (int)(Math.random() * 49.0D) + 1;
	        if (Arytemp[(temp - 1)] == 0)
	        {
	          i--;
	        }
	        else
	        {
	          Arytemp[(temp - 1)] = 0;
	          lottery_95�x��M.btn_num[(temp - 1)].setSelected(true);
	          lottery_95�x��M.btn_num[(temp - 1)].setBackground(new Color(255, 150, 120));
	        }
	      }
	    }
	  }
	 
	 
	 
	 
	 
	 
	 private void choosenum(){
		 
		 
		 if(tex_���a6.getText().length()<=0){
			 JOptionPane.showMessageDialog(null, "�п�J���Ӹ��X");
		 }
		 else
		 {
			 final lottery_95�x��M.MyThread flash1 = new lottery_95�x��M.MyThread(7);
		      flash1.start();
		      Thread wait = new Thread()
		      {
		        public void run()
		        {
		          try
		          {
		            Thread.sleep(1000L);
		            flash1.stoptimer();
		            lottery_95�x��M.this.buttonClear();
		            lottery_95�x��M.this.showoutput();
		          }
		          catch (InterruptedException e)
		          {
		            e.printStackTrace();
		          }
		        }
		      };
		      wait.start();
		 }
		 
	 }
	  
	 private void showoutput()
	 {
		 ArrayList Randomsevens = computerRandom2();
		    String output = "";

		    
		    output = output + "�����}�����X���G//" + Randomsevens.get(0) + "// " + "//" + Randomsevens.get(1) + "// " + "//" + Randomsevens.get(2) + 
		      "// " + "//" + Randomsevens.get(3) + "// " + "//" + Randomsevens.get(4) + "// " + "//" + Randomsevens.get(5) + "// " + 
		      "�S�O���G" + Randomsevens.get(6) + "\n�I������\n\n";
		    

	    	  int special = 0;
		      int matchNum = 0;
		      String price = "";
		      
		        	  if (userList.contains(Randomsevens.get(6)))
			          {
		    	       special = 1;
		    	       
			          }
				      else
			      {
				    	  special = 0;
				      }
		        	  System.out.println(special);
		        	 
		        	  for (int j = 0; j < 6; j++) {
		        	        if (userList.contains(Randomsevens.get(j)))
		        	        {
		        	          matchNum++;
		        	          
		        	        }
		        	      } 
		        	        
		        	 


		      if (matchNum == 6)
		      {
		    	  price = 
		          "���ո��X�襤6�Ӹ��X�G  \n             ���߱z�襤�Y��!";
		        
		      }
		      else if ((matchNum == 5) && (special == 1))
		      {
		    	  price = 
		          "���ո��X�襤5�Ӹ��X�G  \n  ���߱z�襤�L��!";
		        
		      }
		      else if (matchNum == 5)
		      {
		    	  price = 
		          "���ո��X�襤5�Ӹ��X�G  \n              ���߱z�襤�Ѽ�!";
		        
		      }
		      else if ((matchNum == 4) && (special == 1))
		      {
		    	  price = 
		          "���ո��X�襤4�Ӹ��X�G  ���߱z�襤�v��!";
		        
		      }
		      else if (matchNum == 4)
		      {
		    	  price = 
		          "���ո��X�襤4�Ӹ��X�G���߱z�襤���!";
		        
		      }
		      else if ((matchNum == 3) && (special == 1))
		      {
		    	  price = 
		          "���ո��X�襤3�Ӹ��X�G  \n  ���� NT$1,000!";
		        
		      }
		      else if ((matchNum == 2) && (special == 1))
		      {
		    	  price = 
		          "���ո��X�襤2�Ӹ��X�G \n  �m�� NT$400!";
		        
		      }
		      else if (matchNum == 3)
		      {
		    	  price = 
		          "���ո��X�襤3�Ӹ��X�G ���� NT$400!";
		        
		      }
		      else
		      {
		    	  price = 
		          "�z�S�������A���A�F!";
		      }
		         
		      output = output + price + "\n";
		        	   
		        JOptionPane.showMessageDialog(null, output); 
		  
	}
	 
	      
}
