use IA_Project;

CREATE TABLE S_ACTORS(
	ACTOR_ID INT NOT NULL,
	FNAME VARCHAR(100),
	LNAME VARCHAR(100),
	JOB_DESC VARCHAR(50),
	PHOTO IMAGE,
	MOBILE NUMERIC(13,0),
	EMAIL VARCHAR(150),
	AROLE VARCHAR(100),
	USERNAME VARCHAR(200) UNIQUE,
	PASSWORD VARCHAR(200),
	PRIMARY KEY (ACTOR_ID),
);

CREATE TABLE PROJECT(
	PROJECT_ID INT NOT NULL,
	NAME_PROJECT VARCHAR(500),
	DESC_PROJECT VARCHAR(500),
	P_STATUS BIT NOT NULL,
	START_TIME TIME(7) NOT NULL,
	END_TIME TIME(7) NOT NULL,
	PRICE INT NOT NULL,
	PRIMARY KEY(PROJECT_ID)
);

CREATE TABLE ACTOR_PROJECT(
	ACTOR_ID INT NOT NULL,
	PROJECT_ID INT NOT NULL,
	FOREIGN KEY (ACTOR_ID) REFERENCES S_ACTORS(ACTOR_ID),
	FOREIGN KEY (PROJECT_ID) REFERENCES PROJECT(PROJECT_ID),
	AROLE VARCHAR(100),
);

CREATE TABLE S_PAGE(
	PAGE_ID INT NOT NULL,
	PAGE_URL VARCHAR(50),
	ACTOR_ID_P INT NOT NULL,
	PRIMARY KEY(PAGE_ID),
	FOREIGN KEY (ACTOR_ID_P) REFERENCES S_ACTORS(ACTOR_ID) 
);

CREATE TABLE STAT_REPROT(
	ACTOR_ID_R INT NOT NULL,
	NO_PROJECTS INT NOT NULL,
	NO_COMPLETE INT NOT NULL,
	NO_DELV INT NOT NULL,
	NO_CURRENT INT NOT NULL,
	NO_PASSED INT NOT NULL,
	NO_FAILURE INT NOT NULL,
	FOREIGN KEY (ACTOR_ID_R) REFERENCES S_ACTORS(ACTOR_ID)
);

CREATE TABLE EVALUATE(
	ACTOR_ID_FROM INT NOT NULL,
	ACTOR_ID_TO INT NOT NULL,  
	FEED_CONTENT VARCHAR(50) NOT NULL,
	RATE INT NOT NULL,
	FOREIGN KEY (ACTOR_ID_FROM) REFERENCES S_ACTORS(ACTOR_ID),
	FOREIGN KEY (ACTOR_ID_TO) REFERENCES S_ACTORS(ACTOR_ID),
);

CREATE TABLE NOTIF(
	ACTOR_ID_FROM INT NOT NULL,
	ACTOR_ID_TO INT NOT NULL,  
	CONTENT VARCHAR(50) NOT NULL,
	TYPE VARCHAR(50) NOT NULL,
	FOREIGN KEY (ACTOR_ID_FROM) REFERENCES S_ACTORS(ACTOR_ID),
	FOREIGN KEY (ACTOR_ID_TO) REFERENCES S_ACTORS(ACTOR_ID),
);