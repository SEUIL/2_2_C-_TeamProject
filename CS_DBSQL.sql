-- ���� ���̺� �ۼ�
CREATE TABLE USERS ( 
    USERID VARCHAR2(50) PRIMARY KEY,  
    PASSWORD VARCHAR2(50) NOT NULL,   
    EMAIL VARCHAR2(100)               
);

--Ķ���� ���̺� �ۼ�
CREATE TABLE Calendar (
    Id NUMBER PRIMARY KEY,           -- Ķ���� ID
    USERSID VARCHAR2(50) NOT NULL,   -- ����� ID (Users ���̺��� FK)
    Category VARCHAR2(100),          -- ī�װ�
    Time TIMESTAMP,                  -- ���� �ð�
    Description VARCHAR2(500),       -- ���� ��
    Repeats VARCHAR2(100) NULL,      -- �ݺ� (NULL ���)
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

CREATE TABLE Todolist (
   Id NUMBER PRIMARY KEY,   
   Category VARCHAR2(100),    
   Task VARCHAR2(500),   
   Priority VARCHAR2(100), 
   TodoDate TIMESTAMP NULL, 
   Deadline TIMESTAMP NULL, 
   USERID VARCHAR2(50), 
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
DESCRIBE Calendar; -- ���̺� ����Ȯ�� 
SELECT SEQUENCE_NAME FROM USER_SEQUENCES;
