
select top 10  ( p1.user_id) ,p1.distance
from personal_sport_menu p1 , personal_sport_menu p2
where p1.distance <= p2.distance or (p1.distance=p2.distance)
group by p1.user_id , p1.distance 
order by p1.distance desc, p1.user_id desc


select  top 10 distance , user_id 
from personal_sport_menu
group by distance , user_id 
order by distance desc

select distinct top(10) P_Menu_Num,user_id,spdate,distance from personal_sport_menu
 where sport_id=10 
 order by 4 desc
 go




select distance,row_number() over(order by user_id desc) as ID 
from personal_sport_menu
 

 select  user_id as ID,distance,
 DENSE_RANK() OVER(order by distance desc) as rank
 from personal_sport_menu 
 



 select distinct user_id,distance
 from personal_sport_menu 
 
 select distinct user_id,distance
 from personal
