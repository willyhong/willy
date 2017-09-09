use midterm

select * from Store

select * from Order_Master

insert into Order_Master values (1,95,0,0,'¥¿©¾±Æ°©')



Select distinct Product_name From Product  where Store_id = (select Store_id from Order_Master where order_num=2)