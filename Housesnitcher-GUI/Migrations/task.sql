CREATE TABLE tasks (
id int IDENTITY PRIMARY KEY,
title VARCHAR(256),
task_description VARCHAR(MAX) NOT NULL DEFAULT 'No description provided.',
username VARCHAR(50) NOT NULL,
task_status int not null,
dateDue varchar(50) not null,
DateCreated varchar(50) not null,
task_type varchar(50)
)
