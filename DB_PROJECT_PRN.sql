CREATE DATABASE PRN211;
GO

USE PRN211;
GO

-- Bảng vai trò (role)
CREATE TABLE roles (
    id INT PRIMARY KEY,
    [name] NVARCHAR(50) NOT NULL
);
GO

INSERT INTO roles (id, [name]) VALUES
(1, 'Staff'),
(2, 'Mentor'),
(3, 'Member'),
(4, 'Administrator');
Go

-- Bảng người dùng (user)
CREATE TABLE users (
    id INT IDENTITY(1,1) PRIMARY KEY,
    email NVARCHAR(255) NOT NULL,
    [password] NVARCHAR(255) NOT NULL,
    [name] NVARCHAR(255),
    roleId INT,
    FOREIGN KEY (roleId) REFERENCES roles(id)
);
GO

INSERT INTO users (email, [password], [name], roleId) VALUES
('staff@example.com', '1', 'Staff User', 1),
('mentor@example.com', '2', 'Mentor User', 2),
('member@example.com', '3', 'Member User', 3),
('admin@example.com', '4', 'Administrator User', 4);
Go

-- Bảng kiểm tra (test)
CREATE TABLE tests (
    id INT IDENTITY(1,1) PRIMARY KEY,
    title NVARCHAR(255) NOT NULL
);
GO

INSERT INTO tests (title) VALUES
('Practice Test 1'),
('Practice Test 2');
Go

-- Bảng câu hỏi (question)
CREATE TABLE questions (
    id INT IDENTITY(1,1) PRIMARY KEY,
    title NVARCHAR(500) NOT NULL,
    optA NVARCHAR(500) NOT NULL,
    optB NVARCHAR(500) NOT NULL,
    optC NVARCHAR(500) NOT NULL,
    optD NVARCHAR(500) NOT NULL,
    answer NVARCHAR(500) NOT NULL
);
GO

INSERT INTO questions (title, optA, optB, optC, optD, answer) VALUES
('What is 2 + 2?', '3', '4', '5', '6', '4'),
('What is the capital of France?', 'Berlin', 'Madrid', 'Paris', 'London', 'Paris');
Go

-- Bảng hồ sơ (profile)
CREATE TABLE profiles (
	id INT IDENTITY(1,1) PRIMARY KEY,
    userId INT,
    reg_date DATE,
    FOREIGN KEY (userId) REFERENCES users(id)
);
GO

INSERT INTO profiles (userId, reg_date) VALUES
(1, '2023-11-01'),
(2, '2023-11-02'),
(3, '2023-11-03');
Go

-- Bảng slot (slots)
CREATE TABLE slots (
    id INT IDENTITY(1,1) PRIMARY KEY,
    [date] DATE NOT NULL,
    start_time TIME,
    end_time TIME
);
GO

INSERT INTO slots ([date], start_time, end_time) VALUES
('2023-11-01', '09:00:00', '10:30:00'),
('2023-11-01', '11:00:00', '12:30:00');
Go

-- Bảng câu hỏi trong bài kiểm tra (test_question)
CREATE TABLE test_questions (
    id INT IDENTITY(1,1) PRIMARY KEY,
    questionId INT,
    testId INT,
    FOREIGN KEY (questionId) REFERENCES questions(id),
    FOREIGN KEY (testId) REFERENCES tests(id)
);
GO

INSERT INTO test_questions (questionId, testId) VALUES
(1, 1),
(2, 1);
Go


-- Bảng người dùng tham gia kiểm tra (user_tests)
CREATE TABLE user_tests (
	id INT IDENTITY(1,1) PRIMARY KEY,
    userId INT,
    testId INT,
    score INT,
    FOREIGN KEY (userId) REFERENCES users(id),
    FOREIGN KEY (testId) REFERENCES tests(id),
    start_time DATETIME,
    end_time DATETIME
);
GO

INSERT INTO user_tests (userId, testId, score, start_time, end_time) VALUES
(1, 1, 90, '2023-11-01 09:00:00', '2023-11-01 10:00:00'),
(2, 1, 85, '2023-11-01 10:30:00', '2023-11-01 11:30:00'),
(3, 2, 75, '2023-11-01 11:00:00', '2023-11-01 12:00:00');
Go

-- Bảng người dùng và slot (user_slots)
CREATE TABLE user_slots (
	id INT IDENTITY(1,1) PRIMARY KEY,
    userId INT,
    slotId INT,
    FOREIGN KEY (userId) REFERENCES users(id),
    FOREIGN KEY (slotId) REFERENCES slots(id)
);
GO


INSERT INTO user_slots (userId, slotId) VALUES
(1,1),
(2,2),
(3,1);
Go



-- Bảng Mentor (mentors)
CREATE TABLE mentors (
    id INT IDENTITY(1,1) PRIMARY KEY,
    userId INT,
    available_slots INT,
    specialty NVARCHAR(255),
    FOREIGN KEY (userId) REFERENCES users(id)
);
GO

INSERT INTO mentors (userId, available_slots, specialty) VALUES
(2, 2, 'Driving License A'),
(2, 2, 'Driving License B');
Go



-- Bảng đánh giá Mentor (mentor_ratings)
CREATE TABLE mentor_ratings (
    id INT IDENTITY(1,1) PRIMARY KEY,
    userId INT,
    mentorId INT,
    rating INT,
    feedback NVARCHAR(1000),
    FOREIGN KEY (userId) REFERENCES users(id),
    FOREIGN KEY (mentorId) REFERENCES mentors(id)
);
Go
INSERT INTO mentor_ratings (userId, mentorId, rating, feedback) VALUES
(3, 2, 4, 'Good mentor'),
(3, 1, 3, 'Average mentor');
Go

-- Bảng quản lý bài đăng (news_management)
CREATE TABLE news (
    id INT IDENTITY(1,1) PRIMARY KEY,
    title NVARCHAR(255),
    content NVARCHAR(1000),
    post_date DATE
);
Go
INSERT INTO news (title, content, post_date) VALUES
('New Course Announcement', 'We are pleased to announce a new driving course.', '2023-11-01'),
('Mentor Spotlight', 'Meet our top mentor of the month.', '2023-11-02');
Go

-- Bảng khóa học (courses)
CREATE TABLE courses (
    id INT IDENTITY(1,1) PRIMARY KEY,
    title NVARCHAR(255) NOT NULL,
    description NVARCHAR(1000),
    start_date DATE,
    end_date DATE
);
Go
INSERT INTO courses (title, description, start_date, end_date) VALUES
('Driving Course A', 'Course for License A', '2023-11-01', '2023-11-15'),
('Driving Course B', 'Course for License B', '2023-11-01', '2023-11-20');
Go

-- Bảng liên kết giữa khóa học, mentor và slot học (course_mentor_slots)
CREATE TABLE course_mentor_slots (
	id INT IDENTITY(1,1) PRIMARY KEY,
    courseId INT,
    mentorId INT,
    slotId INT,
    FOREIGN KEY (courseId) REFERENCES courses(id),
    FOREIGN KEY (mentorId) REFERENCES mentors(id),
    FOREIGN KEY (slotId) REFERENCES slots(id)
);
Go


INSERT INTO course_mentor_slots (courseId, mentorId, slotId) VALUES
(1, 1, 1), -- Khóa học 1 được Mentor 1 hướng dẫn trong slot 1
(1, 1, 2), -- Khóa học 1 được Mentor 1 hướng dẫn trong slot 2
(2, 2, 1), -- Khóa học 2 được Mentor 2 hướng dẫn trong slot 1
(2, 2, 2); -- Khóa học 2 được Mentor 2 hướng dẫn trong slot 2


-- Bảng liên kết giữa người dùng và khóa học (user_courses)
CREATE TABLE user_courses (
	id INT IDENTITY(1,1) PRIMARY KEY,
    userId INT,
    courseId INT,
    FOREIGN KEY (userId) REFERENCES users(id),
    FOREIGN KEY (courseId) REFERENCES courses(id)
);
Go

INSERT INTO user_courses (userId, courseId) VALUES
(1, 1),
(2, 1),
(3, 2);

-- Bảng đăng ký học (registrations)
CREATE TABLE registrations (
    id INT IDENTITY(1,1) PRIMARY KEY,
    userId INT,
	idCMS INT,
	FOREIGN KEY (idCMS) REFERENCES course_mentor_slots(id),
    FOREIGN KEY (userId) REFERENCES users(id),
);
Go

INSERT INTO registrations (userId, idCMS) VALUES
(2, 1),
(1, 1);
Go

