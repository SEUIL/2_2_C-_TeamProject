-- ���� ���̺� �ۼ�
CREATE TABLE USERS ( 
    USERID VARCHAR2(50) PRIMARY KEY,  
    PASSWORD VARCHAR2(50) NOT NULL,   
    EMAIL VARCHAR2(100)               
);

--Ķ���� ���̺� �ۼ�
CREATE TABLE Calendar (
<<<<<<< HEAD
    Id NUMBER PRIMARY KEY,           -- Ķ���� ID
    USERSID VARCHAR2(50) NOT NULL,   -- ����� ID (Users ���̺��� FK)
    Category VARCHAR2(100),          -- ī�װ�
    Time TIMESTAMP,                  -- ���� �ð�
    Description VARCHAR2(500),       -- ���� ��
    Repeats VARCHAR2(100) NULL,      -- �ݺ� (NULL ���)
=======
    Id NUMBER PRIMARY KEY,           -- 캘린더 ID
    USERSID VARCHAR2(50) NOT NULL,   -- 사용자 ID (Users 테이블의 FK)
    Category VARCHAR2(100),          -- 카테고리
    Time TIMESTAMP,                  -- 일정 시간
    Description VARCHAR2(500),       -- 일정 상세
    Repeats VARCHAR2(100),      -- 반복 (NULL 허용) 
>>>>>>> origin/seuil_ver02
    FOREIGN KEY (USERSID) REFERENCES Users(USERID) ON DELETE CASCADE
);
--Ķ���� ���̺� ���鶧 PK ID�� �ڵ����� (���̺� ���鶧 ���� �ϸ��)
CREATE SEQUENCE SEQ_CALENDAR
START WITH 1
INCREMENT BY 1;

-- SEQ_CALENDAR.NEXTVAL�� Id �ʵ忡 �ڵ����� �Ҵ��ϱ� ���� BEFORE INSERT Ʈ���Ÿ� ����
CREATE OR REPLACE TRIGGER trg_BI_Calendar
BEFORE INSERT ON Calendar
FOR EACH ROW
BEGIN
    IF :NEW.Id IS NULL THEN
        :NEW.Id := SEQ_CALENDAR.NEXTVAL;
    END IF;
END;
/
-- 시퀀스를 삭제
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






-- ������ �ڵ�
SELECT * FROM Users; -- ���̺� ������ Ȯ��
DROP Table USERS --���̺� ����
DELETE FROM users; --���̺� ������ ���� 
DESCRIBE Users; -- ���̺� ����Ȯ�� 

SELECT * FROM Calendar; -- ���̺� ������ Ȯ��
DROP Table calendar; --���̺� ����
DELETE FROM calendar; --���̺� ������ ���� 
DROP SEQUENCE SEQ_CALENDAR; --������ ����
DESC calendar; -- ���̺� ����Ȯ�� 
SELECT SEQUENCE_NAME FROM USER_SEQUENCES;
ALTER SEQUENCE SEQ_CALENDAR RESTART START WITH 1; -- SEQUENCE 값을 리셋하는 방법


DROP Table Todolist


<<<<<<< HEAD















-- ������� searchForm1
=======
-- 디버깅중 searchForm1
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
        



