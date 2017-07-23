package 作業測試;
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

public class lottery_95洪鈺霖 extends JFrame {

	private JPanel contentPane;
	private JLabel lbl開獎號碼;
	private JTextField tex_開獎1;
	private JLabel lbl選擇的號碼;
	private static JTextField tex_玩家1 = new JTextField();
	private JTextField tex_開獎2;
	private JTextField tex_開獎3;
	private JTextField tex_開獎4;
	private JTextField tex_開獎5;
	private JTextField tex_開獎6;
	private JTextField tex_特別號;
	private static JTextField tex_玩家2 = new JTextField();
	private static JTextField tex_玩家3 = new JTextField();
	private static JTextField tex_玩家4 = new JTextField();
	private static JTextField tex_玩家5 = new JTextField();
	private static JTextField tex_玩家6 = new JTextField();
	private static JTextField[] TB_user = { tex_玩家1, tex_玩家2, tex_玩家3, tex_玩家4, tex_玩家5, tex_玩家6 };
	private JLabel label_2;
	private JLabel lbl特別號;
	static JButton[] btn_num = new JButton[49];
	private boolean priceStaus = false;
    static  ArrayList<Integer> userList = new ArrayList<Integer>();
    
    int count = 0;
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					lottery_95洪鈺霖 frame = new lottery_95洪鈺霖();
					frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	
	    
	public lottery_95洪鈺霖() {
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
		label_2.setFont(new Font("微軟正黑體", Font.BOLD, 20));
		label_2.setBackground(new Color(221, 160, 221));
		GridBagConstraints gbc_label_2 = new GridBagConstraints();
		gbc_label_2.gridwidth = 4;
		gbc_label_2.insets = new Insets(0, 0, 5, 5);
		gbc_label_2.gridx = 5;
		gbc_label_2.gridy = 0;
		panel.add(label_2, gbc_label_2);
		
		lbl開獎號碼 = new JLabel("\u958B\u734E\u865F\u78BC:");
		lbl開獎號碼.setBackground(new Color(221, 160, 221));
		lbl開獎號碼.setFont(new Font("微軟正黑體", Font.BOLD, 16));
		GridBagConstraints gbc_lbl開獎號碼 = new GridBagConstraints();
		gbc_lbl開獎號碼.insets = new Insets(0, 0, 5, 5);
		gbc_lbl開獎號碼.anchor = GridBagConstraints.EAST;
		gbc_lbl開獎號碼.gridx = 0;
		gbc_lbl開獎號碼.gridy = 1;
		panel.add(lbl開獎號碼, gbc_lbl開獎號碼);
		
		tex_開獎1 = new JTextField();
		tex_開獎1.setAlignmentY(0.0f);
		tex_開獎1.setAlignmentX(0.0f);
		GridBagConstraints gbc_tex_開獎1 = new GridBagConstraints();
		gbc_tex_開獎1.insets = new Insets(0, 0, 5, 5);
		gbc_tex_開獎1.fill = GridBagConstraints.BOTH;
		gbc_tex_開獎1.gridx = 1;
		gbc_tex_開獎1.gridy = 1;
		panel.add(tex_開獎1, gbc_tex_開獎1);
		tex_開獎1.setColumns(3);
		
		tex_開獎2 = new JTextField();
		tex_開獎2.setColumns(3);
		tex_開獎2.setAlignmentY(0.0f);
		tex_開獎2.setAlignmentX(0.0f);
		GridBagConstraints gbc_tex_開獎2 = new GridBagConstraints();
		gbc_tex_開獎2.insets = new Insets(0, 0, 5, 5);
		gbc_tex_開獎2.fill = GridBagConstraints.HORIZONTAL;
		gbc_tex_開獎2.gridx = 2;
		gbc_tex_開獎2.gridy = 1;
		panel.add(tex_開獎2, gbc_tex_開獎2);
		
		tex_開獎3 = new JTextField();
		tex_開獎3.setColumns(3);
		tex_開獎3.setAlignmentY(0.0f);
		tex_開獎3.setAlignmentX(0.0f);
		GridBagConstraints gbc_tex_開獎3 = new GridBagConstraints();
		gbc_tex_開獎3.insets = new Insets(0, 0, 5, 5);
		gbc_tex_開獎3.fill = GridBagConstraints.HORIZONTAL;
		gbc_tex_開獎3.gridx = 3;
		gbc_tex_開獎3.gridy = 1;
		panel.add(tex_開獎3, gbc_tex_開獎3);
		
		tex_開獎4 = new JTextField();
		tex_開獎4.setColumns(3);
		tex_開獎4.setAlignmentY(0.0f);
		tex_開獎4.setAlignmentX(0.0f);
		GridBagConstraints gbc_tex_開獎4 = new GridBagConstraints();
		gbc_tex_開獎4.insets = new Insets(0, 0, 5, 5);
		gbc_tex_開獎4.fill = GridBagConstraints.HORIZONTAL;
		gbc_tex_開獎4.gridx = 4;
		gbc_tex_開獎4.gridy = 1;
		panel.add(tex_開獎4, gbc_tex_開獎4);
		
		tex_開獎5 = new JTextField();
		tex_開獎5.setColumns(3);
		tex_開獎5.setAlignmentY(0.0f);
		tex_開獎5.setAlignmentX(0.0f);
		GridBagConstraints gbc_tex_開獎5 = new GridBagConstraints();
		gbc_tex_開獎5.insets = new Insets(0, 0, 5, 5);
		gbc_tex_開獎5.fill = GridBagConstraints.HORIZONTAL;
		gbc_tex_開獎5.gridx = 5;
		gbc_tex_開獎5.gridy = 1;
		panel.add(tex_開獎5, gbc_tex_開獎5);
		
		tex_開獎6 = new JTextField();
		tex_開獎6.setColumns(3);
		tex_開獎6.setAlignmentY(0.0f);
		tex_開獎6.setAlignmentX(0.0f);
		GridBagConstraints gbc_tex_開獎6 = new GridBagConstraints();
		gbc_tex_開獎6.insets = new Insets(0, 0, 5, 5);
		gbc_tex_開獎6.fill = GridBagConstraints.HORIZONTAL;
		gbc_tex_開獎6.gridx = 6;
		gbc_tex_開獎6.gridy = 1;
		panel.add(tex_開獎6, gbc_tex_開獎6);
		
		lbl特別號 = new JLabel("\u7279\u5225\u865F\u78BC:");
		lbl特別號.setFont(new Font("微軟正黑體", Font.BOLD, 16));
		lbl特別號.setBackground(new Color(221, 160, 221));
		GridBagConstraints gbc_lbl特別號 = new GridBagConstraints();
		gbc_lbl特別號.insets = new Insets(0, 0, 5, 5);
		gbc_lbl特別號.anchor = GridBagConstraints.EAST;
		gbc_lbl特別號.gridx = 7;
		gbc_lbl特別號.gridy = 1;
		panel.add(lbl特別號, gbc_lbl特別號);
		
		tex_特別號 = new JTextField();
		tex_特別號.setColumns(3);
		tex_特別號.setAlignmentY(0.0f);
		tex_特別號.setAlignmentX(0.0f);
		GridBagConstraints gbc_tex_特別號 = new GridBagConstraints();
		gbc_tex_特別號.insets = new Insets(0, 0, 5, 5);
		gbc_tex_特別號.fill = GridBagConstraints.HORIZONTAL;
		gbc_tex_特別號.gridx = 8;
		gbc_tex_特別號.gridy = 1;
		panel.add(tex_特別號, gbc_tex_特別號);
		
		lbl選擇的號碼 = new JLabel("\u60A8\u9078\u64C7\u7684\u865F\u78BC:");
		lbl選擇的號碼.setFont(new Font("微軟正黑體", Font.BOLD, 16));
		lbl選擇的號碼.setBackground(new Color(221, 160, 221));
		GridBagConstraints gbc_lbl選擇的號碼 = new GridBagConstraints();
		gbc_lbl選擇的號碼.anchor = GridBagConstraints.EAST;
		gbc_lbl選擇的號碼.insets = new Insets(0, 0, 0, 5);
		gbc_lbl選擇的號碼.gridx = 0;
		gbc_lbl選擇的號碼.gridy = 2;
		panel.add(lbl選擇的號碼, gbc_lbl選擇的號碼);
		
		
		tex_玩家1.setColumns(3);
		tex_玩家1.setAlignmentY(0.0f);
		tex_玩家1.setAlignmentX(0.0f);
		GridBagConstraints gbc_tex_玩家1 = new GridBagConstraints();
		gbc_tex_玩家1.insets = new Insets(0, 0, 0, 5);
		gbc_tex_玩家1.fill = GridBagConstraints.HORIZONTAL;
		gbc_tex_玩家1.gridx = 1;
		gbc_tex_玩家1.gridy = 2;
		panel.add(tex_玩家1, gbc_tex_玩家1);
		
		
		tex_玩家2.setColumns(3);
		tex_玩家2.setAlignmentY(0.0f);
		tex_玩家2.setAlignmentX(0.0f);
		GridBagConstraints gbc_tex_玩家2 = new GridBagConstraints();
		gbc_tex_玩家2.insets = new Insets(0, 0, 0, 5);
		gbc_tex_玩家2.fill = GridBagConstraints.HORIZONTAL;
		gbc_tex_玩家2.gridx = 2;
		gbc_tex_玩家2.gridy = 2;
		panel.add(tex_玩家2, gbc_tex_玩家2);
		
		
		tex_玩家3.setColumns(3);
		tex_玩家3.setAlignmentY(0.0f);
		tex_玩家3.setAlignmentX(0.0f);
		GridBagConstraints gbc_tex_玩家3 = new GridBagConstraints();
		gbc_tex_玩家3.insets = new Insets(0, 0, 0, 5);
		gbc_tex_玩家3.fill = GridBagConstraints.HORIZONTAL;
		gbc_tex_玩家3.gridx = 3;
		gbc_tex_玩家3.gridy = 2;
		panel.add(tex_玩家3, gbc_tex_玩家3);
		
		
		tex_玩家4.setColumns(3);
		tex_玩家4.setAlignmentY(0.0f);
		tex_玩家4.setAlignmentX(0.0f);
		GridBagConstraints gbc_tex_玩家4 = new GridBagConstraints();
		gbc_tex_玩家4.insets = new Insets(0, 0, 0, 5);
		gbc_tex_玩家4.fill = GridBagConstraints.HORIZONTAL;
		gbc_tex_玩家4.gridx = 4;
		gbc_tex_玩家4.gridy = 2;
		panel.add(tex_玩家4, gbc_tex_玩家4);
		
		
		tex_玩家5.setColumns(3);
		tex_玩家5.setAlignmentY(0.0f);
		tex_玩家5.setAlignmentX(0.0f);
		GridBagConstraints gbc_tex_玩家5 = new GridBagConstraints();
		gbc_tex_玩家5.insets = new Insets(0, 0, 0, 5);
		gbc_tex_玩家5.fill = GridBagConstraints.HORIZONTAL;
		gbc_tex_玩家5.gridx = 5;
		gbc_tex_玩家5.gridy = 2;
		panel.add(tex_玩家5, gbc_tex_玩家5);
		
		
		tex_玩家6.setColumns(3);
		tex_玩家6.setAlignmentY(0.0f);
		tex_玩家6.setAlignmentX(0.0f);
		GridBagConstraints gbc_tex_玩家6 = new GridBagConstraints();
		gbc_tex_玩家6.insets = new Insets(0, 0, 0, 5);
		gbc_tex_玩家6.fill = GridBagConstraints.HORIZONTAL;
		gbc_tex_玩家6.gridx = 6;
		gbc_tex_玩家6.gridy = 2;
		panel.add(tex_玩家6, gbc_tex_玩家6);
		
		JButton btn開獎 = new JButton("\u958B\u734E");
		btn開獎.addActionListener(new ActionListener()
	    {
	      public void actionPerformed(ActionEvent arg0)
	      {
	    	  lottery_95洪鈺霖.this.choosenum();
	    	  lottery_95洪鈺霖.this.priceStaus = true;
	      }
	    });
		GridBagConstraints gbc_btn開獎 = new GridBagConstraints();
		gbc_btn開獎.insets = new Insets(0, 0, 0, 5);
		gbc_btn開獎.gridx = 7;
		gbc_btn開獎.gridy = 2;
		panel.add(btn開獎, gbc_btn開獎);
		btn開獎.setFont(new Font("微軟正黑體", Font.BOLD, 18));
		btn開獎.setBounds(new Rectangle(10, 10, 15, 15));
		btn開獎.setBorder(new CompoundBorder(new BevelBorder(BevelBorder.RAISED, null, null, null, null), new EmptyBorder(3, 8, 3, 8)));
		btn開獎.setBackground(new Color(255, 255, 0));
		
				
				JButton btn選號 = new JButton("\u81EA\u52D5\u9078\u865F");
				btn選號.addActionListener(new ActionListener()
	    {
	      public void actionPerformed(ActionEvent arg0)
	      {
	    	  lottery_95洪鈺霖.this.clearTB();
	          final lottery_95洪鈺霖.MyThread flash1 = new lottery_95洪鈺霖.MyThread(6);
	        flash1.start();
	        new Thread()
	        {
	          public void run()
	          {
	            try
	            {
	              Thread.sleep(1000L);
	              flash1.stoptimer();
	              lottery_95洪鈺霖.this.buttonClear();
	              lottery_95洪鈺霖.this.com2();
	            }
	            catch (InterruptedException e)
	            {
	              e.printStackTrace();
	            }
	          }
	        }.start();
	        lottery_95洪鈺霖.this.clearPriceTB();
	      }
	    });		
				GridBagConstraints gbc_btn選號 = new GridBagConstraints();
				gbc_btn選號.insets = new Insets(0, 0, 0, 5);
				gbc_btn選號.gridx = 8;
				gbc_btn選號.gridy = 2;
				panel.add(btn選號, gbc_btn選號);
				btn選號.setFont(new Font("微軟正黑體", Font.BOLD, 18));
				btn選號.setBounds(new Rectangle(10, 10, 6, 6));
				btn選號.setBorder(new CompoundBorder(new BevelBorder(BevelBorder.RAISED, null, null, null, null), new EmptyBorder(3, 8, 3, 8)));
				btn選號.setBackground(new Color(106, 90, 205));
		
				
				
				JButton btn清除 = new JButton("\u6E05\u9664\u9078\u865F");
				btn清除.addActionListener
				(new ActionListener()
	    {
	      public void actionPerformed(ActionEvent arg0)
	      {
	    	  lottery_95洪鈺霖.this.clearTB();
	    	  lottery_95洪鈺霖.this.clearPriceTB();
	    	  lottery_95洪鈺霖.this.buttonClear();
	    	  lottery_95洪鈺霖.this.userList.removeAll(lottery_95洪鈺霖.userList);
	    	  
	      }
	    });
				GridBagConstraints gbc_btn清除 = new GridBagConstraints();
				gbc_btn清除.insets = new Insets(0, 0, 0, 5);
				gbc_btn清除.fill = GridBagConstraints.HORIZONTAL;
				gbc_btn清除.gridx = 9;
				gbc_btn清除.gridy = 2;
				panel.add(btn清除, gbc_btn清除);
				btn清除.setFont(new Font("微軟正黑體", Font.BOLD, 18));
				btn清除.setBorder(new CompoundBorder(new BevelBorder(BevelBorder.RAISED, null, null, null, null), new EmptyBorder(3, 8, 3, 8)));
				btn清除.setBackground(new Color(255, 0, 0));
				btn清除.setAlignmentX(10.0f);
				btn清除.setSelected(true);
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
	      btn_num[i].setFont(new Font("微軟正黑體", 1, 14));
	      btn_num[i].setSelected(false);
	      panel_1.add(btn_num[i]);
	      
	      btn_num[i].addActionListener(new lottery_95洪鈺霖.buttonActionListener());
	     }
		

	  }
	
	
	class buttonActionListener
    implements ActionListener
    {
		buttonActionListener() {}
		 public void actionPerformed(ActionEvent e)
		    {
			 if(lottery_95洪鈺霖.this.priceStaus)
			 {
				 
				 lottery_95洪鈺霖.this.clearTB();
				 lottery_95洪鈺霖.this.clearPriceTB();
				 lottery_95洪鈺霖.this.buttonClear();
				 lottery_95洪鈺霖.userList.removeAll(lottery_95洪鈺霖.userList);
				 lottery_95洪鈺霖.this.priceStaus = false;
			      
			 }

		      if (lottery_95洪鈺霖.this.count < 6) {
		        for (int j = 0; j < 49; j++) {
		          if (e.getSource() == lottery_95洪鈺霖.btn_num[j]) {
		            if (lottery_95洪鈺霖.btn_num[j].isSelected())
		            {
		            	lottery_95洪鈺霖.btn_num[j].setSelected(false);
		            	lottery_95洪鈺霖.btn_num[j].setBackground(new Color(250, 192, 192));
		              
		            	lottery_95洪鈺霖.userList.remove(Integer.valueOf(Integer.parseInt(lottery_95洪鈺霖.btn_num[j].getText())));
		              lottery_95洪鈺霖.this.count -= 1;
		            }
		            else
		            {
		            	lottery_95洪鈺霖.btn_num[j].setSelected(true);
		            	lottery_95洪鈺霖.btn_num[j].setBackground(new Color(255, 50, 50));
		              
		            	lottery_95洪鈺霖.userList.add(Integer.valueOf(Integer.parseInt(lottery_95洪鈺霖.btn_num[j].getText())));
		            	lottery_95洪鈺霖.this.count += 1;
		            }
		          }
		        }
		      } else {
		        for (int j = 0; j < 49; j++) {
		          if (e.getSource() == lottery_95洪鈺霖.btn_num[j]) {
		            if (lottery_95洪鈺霖.btn_num[j].isSelected())
		            {
		            	lottery_95洪鈺霖.btn_num[j].setSelected(false);
		            	lottery_95洪鈺霖.btn_num[j].setBackground(new Color(250, 192, 192));
		            	lottery_95洪鈺霖.userList.remove(Integer.valueOf(lottery_95洪鈺霖.btn_num[j].getText()));
		            	lottery_95洪鈺霖.this.count -= 1;
		            }
		            else
		            {
		              JOptionPane.showMessageDialog(null, "您已經選了6個數字");
		            }
		          }
		        }
		      }
		      Collections.sort(lottery_95洪鈺霖.userList);
		      lottery_95洪鈺霖.this.printNum(lottery_95洪鈺霖.userList);
		    
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
	    this.tex_開獎1.setText("");
	    this.tex_開獎2.setText("");
	    this.tex_開獎3.setText("");
	    this.tex_開獎4.setText("");
	    this.tex_開獎5.setText("");
	    this.tex_開獎6.setText("");
	    this.tex_特別號.setText("");
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
	    this.tex_特別號.setText(String.format("%02d", new Object[] { RandomSeven.get(6) }));
	    RandomSeven.remove(6);
	    
	    Collections.sort(RandomSeven);
	    this.tex_開獎1.setText(String.format("%02d", new Object[] { RandomSeven.get(0) }));
	    this.tex_開獎2.setText(String.format("%02d", new Object[] { RandomSeven.get(1) }));
	    this.tex_開獎3.setText(String.format("%02d", new Object[] { RandomSeven.get(2) }));
	    this.tex_開獎4.setText(String.format("%02d", new Object[] { RandomSeven.get(3) }));
	    this.tex_開獎5.setText(String.format("%02d", new Object[] { RandomSeven.get(4) }));
	    this.tex_開獎6.setText(String.format("%02d", new Object[] { RandomSeven.get(5) }));
	    RandomSeven.add(Integer.valueOf(Integer.parseInt(this.tex_特別號.getText())));
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
	        	  lottery_95洪鈺霖.userList.add(Integer.valueOf(temp));
	            Arytemp[(temp - 1)] = 0;
	            lottery_95洪鈺霖.btn_num[(temp - 1)].setSelected(true);
	            lottery_95洪鈺霖.btn_num[(temp - 1)].setBackground(new Color(255, 160, 122));
	            lottery_95洪鈺霖.this.count += 1;
	            lottery_95洪鈺霖.TB_user[i].setText(String.format("%02d", new Object[] {lottery_95洪鈺霖.userList.get(i) }));
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
	        Collections.sort(lottery_95洪鈺霖.userList);
	        for (int i = 0; i < lottery_95洪鈺霖.userList.size(); i++) {
	        	lottery_95洪鈺霖.TB_user[i].setText(String.format("%02d", new Object[] { lottery_95洪鈺霖.userList.get(i) }));
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
	      this.timer1.schedule(new lottery_95洪鈺霖.DateTask(this.Max), 0L, 100L);
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
	    	  lottery_95洪鈺霖.btn_num[j].setSelected(false);
	    	  lottery_95洪鈺霖.btn_num[j].setBackground(new Color(50, 50, 192));
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
	          lottery_95洪鈺霖.btn_num[(temp - 1)].setSelected(true);
	          lottery_95洪鈺霖.btn_num[(temp - 1)].setBackground(new Color(255, 150, 120));
	        }
	      }
	    }
	  }
	 
	 
	 
	 
	 
	 
	 private void choosenum(){
		 
		 
		 if(tex_玩家6.getText().length()<=0){
			 JOptionPane.showMessageDialog(null, "請輸入六個號碼");
		 }
		 else
		 {
			 final lottery_95洪鈺霖.MyThread flash1 = new lottery_95洪鈺霖.MyThread(7);
		      flash1.start();
		      Thread wait = new Thread()
		      {
		        public void run()
		        {
		          try
		          {
		            Thread.sleep(1000L);
		            flash1.stoptimer();
		            lottery_95洪鈺霖.this.buttonClear();
		            lottery_95洪鈺霖.this.showoutput();
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

		    
		    output = output + "本期開獎號碼為：//" + Randomsevens.get(0) + "// " + "//" + Randomsevens.get(1) + "// " + "//" + Randomsevens.get(2) + 
		      "// " + "//" + Randomsevens.get(3) + "// " + "//" + Randomsevens.get(4) + "// " + "//" + Randomsevens.get(5) + "// " + 
		      "特別號：" + Randomsevens.get(6) + "\n兌獎明細\n\n";
		    

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
		          "本組號碼對中6個號碼：  \n             恭喜您對中頭獎!";
		        
		      }
		      else if ((matchNum == 5) && (special == 1))
		      {
		    	  price = 
		          "本組號碼對中5個號碼：  \n  恭喜您對中貳獎!";
		        
		      }
		      else if (matchNum == 5)
		      {
		    	  price = 
		          "本組號碼對中5個號碼：  \n              恭喜您對中參獎!";
		        
		      }
		      else if ((matchNum == 4) && (special == 1))
		      {
		    	  price = 
		          "本組號碼對中4個號碼：  恭喜您對中肆獎!";
		        
		      }
		      else if (matchNum == 4)
		      {
		    	  price = 
		          "本組號碼對中4個號碼：恭喜您對中伍獎!";
		        
		      }
		      else if ((matchNum == 3) && (special == 1))
		      {
		    	  price = 
		          "本組號碼對中3個號碼：  \n  陸獎 NT$1,000!";
		        
		      }
		      else if ((matchNum == 2) && (special == 1))
		      {
		    	  price = 
		          "本組號碼對中2個號碼： \n  柒獎 NT$400!";
		        
		      }
		      else if (matchNum == 3)
		      {
		    	  price = 
		          "本組號碼對中3個號碼： 普獎 NT$400!";
		        
		      }
		      else
		      {
		    	  price = 
		          "您沒有中獎再接再厲!";
		      }
		         
		      output = output + price + "\n";
		        	   
		        JOptionPane.showMessageDialog(null, output); 
		  
	}
	 
	      
}
