-- ю╞юЗ евюл╨М юш╪╨
CREATE TABLE USERS ( 
    USERID VARCHAR2(50) PRIMARY KEY,  
    PASSWORD VARCHAR2(50) NOT NULL,   
    EMAIL VARCHAR2(100)               
);

--д╤╦╟╢У евюл╨М юш╪╨
CREATE TABLE Calendar (
<<<<<<< HEAD
    Id NUMBER PRIMARY KEY,           -- д╤╦╟╢У ID
    USERSID VARCHAR2(50) NOT NULL,   -- ╩Г©Кюз ID (Users евюл╨Мюг FK)
    Category VARCHAR2(100),          -- д╚ев╟М╦╝
    Time TIMESTAMP,                  -- юоа╓ ╫ц╟ё
    Description VARCHAR2(500),       -- юоа╓ ╩С╪╪
    Repeats VARCHAR2(100) NULL,      -- ╧щ╨╧ (NULL гЦ©К)
=======
    Id NUMBER PRIMARY KEY,           -- Л╨≤К╕╟К█■ ID
    USERSID VARCHAR2(50) NOT NULL,   -- Л┌╛Л ╘Л·░ ID (Users М┘▄Л²╢К╦■Л²≤ FK)
    Category VARCHAR2(100),          -- Л╧╢М┘▄ЙЁ═К╕╛
    Time TIMESTAMP,                  -- Л²╪Л═∙ Л▀°Й╟└
    Description VARCHAR2(500),       -- Л²╪Л═∙ Л┐│Л└╦
    Repeats VARCHAR2(100),      -- К╟≤КЁ╣ (NULL М≈┬Л ╘) 
>>>>>>> origin/seuil_ver02
    FOREIGN KEY (USERSID) REFERENCES Users(USERID) ON DELETE CASCADE
);
--д╤╦╟╢У евюл╨М ╦╦╣И╤╖ PK ID╟╙ юз╣©аУ╟║ (евюл╨М ╦╦╣И╤╖ ╟╟юл го╦И┴н)
CREATE SEQUENCE SEQ_CALENDAR
START WITH 1
INCREMENT BY 1;

-- SEQ_CALENDAR.NEXTVALю╩ Id гй╣Е©║ юз╣©ю╦╥н гр╢Гго╠Б ю╖гь BEFORE INSERT ф╝╦╝╟е╦╕ ╩Щ╪╨
CREATE OR REPLACE TRIGGER trg_BI_Calendar
BEFORE INSERT ON Calendar
FOR EACH ROW
BEGIN
    IF :NEW.Id IS NULL THEN
        :NEW.Id := SEQ_CALENDAR.NEXTVAL;
    END IF;
END;
/
-- Л▀°М──Л┼╓К╔╪ Л┌╜Л═°
DROP SEQUENCE SEQ_CALENDAR;


CREATE TABLE Todolist (
   Id NUMBER PRIMARY KEY,
   Category VARCHAR2(100),
   Task VARCHAR2(500),
   Priority VARCHAR2(100), 
   TodoDate TIMESTAMP NULL, 
   Deadline TIMESTAMP NULL, 
   USERID VARCHAR2(50), 
   IS_COMPLETED NUMBER(1) DEFAULT 0 NOT NULL,
   CONSTRAINT fk_todolist_userid FOREIGN KEY (USERID) REFERENCES USERS(USERID)
);

CREATE SEQUENCE SEQ_Todolist
START WITH 1
INCREMENT BY 1; 






-- ╣П╧Ж╠К©К дз╣Е
SELECT * FROM Users; -- евюл╨М ╣╔юлем х╝юн
DROP Table USERS --евюл╨М ╩Ха╕
DELETE FROM users; --евюл╨М евюлем ╩Ха╕ 
DESCRIBE Users; -- евюл╨М ╠╦а╤х╝юн 

SELECT * FROM Calendar; -- евюл╨М ╣╔юлем х╝юн
DROP Table calendar; --евюл╨М ╩Ха╕
DELETE FROM calendar; --евюл╨М евюлем ╩Ха╕ 
DROP SEQUENCE SEQ_CALENDAR; --╫цдЖ╫╨ ╩Ха╕
DESC calendar; -- евюл╨М ╠╦а╤х╝юн 
SELECT SEQUENCE_NAME FROM USER_SEQUENCES;
ALTER SEQUENCE SEQ_CALENDAR RESTART START WITH 1; -- SEQUENCE Й╟▓Л²└ К╕╛Л┘▀М∙≤К┼■ К╟╘К╡∙


DROP Table Todolist


<<<<<<< HEAD















-- ╣П╧Ж╠Каъ searchForm1
=======
-- К■■К╡└Й╧┘Л╓▒ searchForm1
>>>>>>> origin/seuil_ver02
SELECT category, time, description, repeats
FROM Calendar
WHERE usersId = :userId
AND description LIKE :searchKeyword
AND time BETWEEN :startDate AND :endDate;

SELECT category, time, description, repeats
FROM Calendar
WHERE USERSID = 'test'
  AND description LIKE '%1111%'
  AND time BETWEEN TO_DATE('2024-11-01 00:00:00', 'YYYY-MM-DD HH24:MI:SS') 
                 AND TO_DATE('2024-11-30 23:59:59', 'YYYY-MM-DD HH24:MI:SS');
        



