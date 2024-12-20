-- 유저 테이블 작성
CREATE TABLE USERS ( 
    USERID VARCHAR2(50) PRIMARY KEY,  
    PASSWORD VARCHAR2(50) NOT NULL,   
    EMAIL VARCHAR2(100)               
);

--캘린더 테이블 작성
CREATE TABLE Calendar (
<<<<<<< HEAD
    Id NUMBER PRIMARY KEY,           -- 캘린더 ID
    USERSID VARCHAR2(50) NOT NULL,   -- 사용자 ID (Users 테이블의 FK)
    Category VARCHAR2(100),          -- 카테고리
    Time TIMESTAMP,                  -- 일정 시간
    Description VARCHAR2(500),       -- 일정 상세
    Repeats VARCHAR2(100) NULL,      -- 반복 (NULL 허용)
=======
    Id NUMBER PRIMARY KEY,           -- 罹섎┛�뜑 ID
    USERSID VARCHAR2(50) NOT NULL,   -- �궗�슜�옄 ID (Users �뀒�씠釉붿쓽 FK)
    Category VARCHAR2(100),          -- 移댄뀒怨좊━
    Time TIMESTAMP,                  -- �씪�젙 �떆媛�
    Description VARCHAR2(500),       -- �씪�젙 �긽�꽭
    Repeats VARCHAR2(100),      -- 諛섎났 (NULL �뿀�슜) 
>>>>>>> origin/seuil_ver02
    FOREIGN KEY (USERSID) REFERENCES Users(USERID) ON DELETE CASCADE
);
--캘린더 테이블 만들때 PK ID값 자동증가 (테이블 만들때 같이 하면됌)
CREATE SEQUENCE SEQ_CALENDAR
START WITH 1
INCREMENT BY 1;

-- SEQ_CALENDAR.NEXTVAL을 Id 필드에 자동으로 할당하기 위해 BEFORE INSERT 트리거를 생성
CREATE OR REPLACE TRIGGER trg_BI_Calendar
BEFORE INSERT ON Calendar
FOR EACH ROW
BEGIN
    IF :NEW.Id IS NULL THEN
        :NEW.Id := SEQ_CALENDAR.NEXTVAL;
    END IF;
END;
/
-- �떆����뒪瑜� �궘�젣
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






-- 디버깅용 코드
SELECT * FROM Users; -- 테이블 데이터 확인
DROP Table USERS --테이블 삭제
DELETE FROM users; --테이블 테이터 삭제 
DESCRIBE Users; -- 테이블 구조확인 

SELECT * FROM Calendar; -- 테이블 데이터 확인
DROP Table calendar; --테이블 삭제
DELETE FROM calendar; --테이블 테이터 삭제 
DROP SEQUENCE SEQ_CALENDAR; --시퀀스 삭제
DESC calendar; -- 테이블 구조확인 
SELECT SEQUENCE_NAME FROM USER_SEQUENCES;
ALTER SEQUENCE SEQ_CALENDAR RESTART START WITH 1; -- SEQUENCE 媛믪쓣 由ъ뀑�븯�뒗 諛⑸쾿


DROP Table Todolist


<<<<<<< HEAD















-- 디버깅중 searchForm1
=======
-- �뵒踰꾧퉭以� searchForm1
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
        



