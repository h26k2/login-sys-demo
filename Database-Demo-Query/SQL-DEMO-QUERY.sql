

-- Demo Query for Login System


-- Creating Database

create database LoginSystem;
use LoginSystem;

-- Creating Tables

create table login_details (name varchar(30) , email varchar(30) , pass varchar(30),
username varchar(30))

create table pass_req_details (email varchar(30) , code varchar(30) );

--Adding Some Records

insert into login_details (name , email , pass, username) values ('ENTER_PERSON_NAME_HERE',
'ENTER_PERSON_EMAIL_HERE','ENTER_PERSON_PASSWORD_HERE','ENTER_PERSON_USERNAME_HERE')


-- Some Basic Operations

select * from pass_req_details;
select * from login_details

