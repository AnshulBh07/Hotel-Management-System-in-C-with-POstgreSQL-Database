create table rooms(
    roomid serial not null,
    roomno varchar not null unique,
    roomtype varchar not null,
    bed varchar not null,
    price int not null,
    booked varchar default 'NO',
    primary key(roomid)
)

--inserting sample room data
insert into rooms values(1,'B-100','AC','Double',5000);
select * from rooms;

create table customers(
    cust_id serial not null unique,
    name varchar not null,
    mobile_No bigint not null,
    nationality varchar not null,
    gender varchar not null,
    date_of_birth varchar not null,
    id_proof varchar not null unique,
    address varchar(350) not null,
    checkin varchar not null,
    checkout varchar,
    co_status varchar not null default 'NO',
    roomid int not null,
    foreign key(roomid) references rooms(roomid)
)

select * from customers;

create table employee(
    empid serial not null,
    emp_name varchar not null,
    emp_mobile varchar not null,
    emp_mail varchar not null,
    username varchar not null,
    password varchar not null,
    primary key(empid)
)

select * from employee;

select a.cust_id,a.name,a.mobile_no,a.checkin,
b.roomno,b.bed,b.roomtype,b.price from customers a
full join rooms b on a.roomid = b.roomid;

update rooms set booked = 'YES' where roomno = 'C-201';