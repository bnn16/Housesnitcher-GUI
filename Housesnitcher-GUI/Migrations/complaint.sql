create table complaints(
id int not null Identity(1,1) primary key, 
title varchar(250) not null,
complaint_description varchar(250) not null,
username varchar(250) not null,
complaint_type varchar(250) not null,
complaint_status int,
complaint_feedback varchar(250),
date_happened datetime not null,
date_created datetime not null,
)
