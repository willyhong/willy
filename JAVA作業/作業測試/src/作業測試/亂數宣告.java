package �@�~����;
public class �üƫŧi {

	public static void main(String[] args) {
		
		int num [] = new  int[7];
		boolean flag;
		
		for(int i =0;i<=6;i++)
		{
			do{
				flag = false;
				num[i] = (int) (Math.random()*49)+1;
				if(i!=0)
				{
					for(int j=0;j<i;j++)
					{
						if (num[i] == num[j])
					     {
							flag = true;	
					       }
						
					}
					
					
				}
			}while(flag);
			if (i<6)
			{
				System.out.print("��"+(i+1)+"��:\n");
			}
			else {
				System.out.print("�S�O��:");
			}
			if (num[i]<10)
			{
				System.out.println("0"+num[i]);
			}
			else {
				System.out.println(num[i]);
			}
		}
		
	  }

	}

