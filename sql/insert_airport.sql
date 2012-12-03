begin;

select * from AIRPORT;

insert into AIRPORT (NAME, CITY) values ('ATL', 'Atlanta');
insert into AIRPORT (NAME, CITY) values ('ORD', 'Chicago');
insert into AIRPORT (NAME, CITY) values ('LHR', 'London');
insert into AIRPORT (NAME, CITY) values ('HND', 'Tokyo');
insert into AIRPORT (NAME, CITY) values ('LAX', 'Los Angeles');
insert into AIRPORT (NAME, CITY) values ('DFW', 'Dallas');
insert into AIRPORT (NAME, CITY) values ('FRA', 'Frankfurt');
insert into AIRPORT (NAME, CITY) values ('CDR', 'Paris');
insert into AIRPORT (NAME, CITY) values ('AMS', 'Amsterdam');
insert into AIRPORT (NAME, CITY) values ('DEN', 'Denver');
insert into AIRPORT (NAME, CITY) values ('PHX', 'Phoenix');
insert into AIRPORT (NAME, CITY) values ('LAS', 'Las Vegas');
insert into AIRPORT (NAME, CITY) values ('MAD', 'Madrid');
insert into AIRPORT (NAME, CITY) values ('IAH', 'Houston');
insert into AIRPORT (NAME, CITY) values ('HKG', 'Hong Kong');
insert into AIRPORT (NAME, CITY) values ('MSP', 'Minneapolis');
insert into AIRPORT (NAME, CITY) values ('DTW', 'Detroit');
insert into AIRPORT (NAME, CITY) values ('DMK', 'Bangkok');
insert into AIRPORT (NAME, CITY) values ('SFO', 'San Francisco');
insert into AIRPORT (NAME, CITY) values ('YYC', 'Calgary');

select * from AIRPORT;

rollback;
