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


-- Bảng người dùng (user)
CREATE TABLE users (
    id INT PRIMARY KEY,
    email NVARCHAR(255) NOT NULL,
    [password] NVARCHAR(255) NOT NULL,
    [name] NVARCHAR(255),
    roleId INT,
    FOREIGN KEY (roleId) REFERENCES roles(id)
);
GO

INSERT INTO users (id, email, [password], [name], roleId) VALUES
(1, 'staff@example.com', '1', 'Staff User', 1),
(2, 'mentor@example.com', '2', 'Mentor User', 2),
(3, 'member@example.com', '3', 'Member User', 3),
(4, 'admin@example.com', '4', 'Administrator User', 4);


-- Bảng kiểm tra (test)
CREATE TABLE tests (
    id INT PRIMARY KEY,
    title NVARCHAR(255) NOT NULL
);
GO

INSERT INTO tests (id, title) VALUES
(1, 'Practice Test 1'),
(2, 'Practice Test 2');


-- Bảng câu hỏi (question)
CREATE TABLE questions (
    id INT PRIMARY KEY,
    title NVARCHAR(500) NOT NULL,
    optA NVARCHAR(500) NOT NULL,
    optB NVARCHAR(500) NOT NULL,
    optC NVARCHAR(500) NOT NULL,
    optD NVARCHAR(500) NOT NULL,
    answer NVARCHAR(500) NOT NULL
);
GO

INSERT INTO questions (id, title, optA, optB, optC, optD, answer) VALUES
(1, 'What is 2 + 2?', '3', '4', '5', '6', '4'),
(2, 'What is the capital of France?', 'Berlin', 'Madrid', 'Paris', 'London', 'Paris');


-- Bảng hồ sơ (profile)
CREATE TABLE profiles (
    userId INT PRIMARY KEY,
    reg_date DATE,
    FOREIGN KEY (userId) REFERENCES users(id)
);
GO

INSERT INTO profiles (userId, reg_date) VALUES
(1, '2023-11-01'),
(2, '2023-11-02'),
(3, '2023-11-03');


-- Bảng slot (slots)
CREATE TABLE slots (
    id INT PRIMARY KEY,
    [date] DATE NOT NULL,
    start_time TIME,
    end_time TIME
);
GO

INSERT INTO slots (id, [date], start_time, end_time) VALUES
(1, '2023-11-01', '09:00:00', '10:30:00'),
(2, '2023-11-01', '11:00:00', '12:30:00');


-- Bảng câu hỏi trong bài kiểm tra (test_question)
CREATE TABLE test_questions (
    id INT PRIMARY KEY,
    questionId INT,
    testId INT,
    FOREIGN KEY (questionId) REFERENCES questions(id),
    FOREIGN KEY (testId) REFERENCES tests(id)
);
GO

INSERT INTO test_questions (id, questionId, testId) VALUES
(1, 1, 1),
(2, 2, 1);



-- Bảng người dùng tham gia kiểm tra (user_tests)
CREATE TABLE user_tests (
    userId INT,
    testId INT,
    score INT,
    PRIMARY KEY (userId, testId),
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


-- Bảng người dùng và slot (user_slots)
CREATE TABLE user_slots (
    userId INT,
    slotId INT,
    PRIMARY KEY (userId, slotId),
    FOREIGN KEY (userId) REFERENCES users(id),
    FOREIGN KEY (slotId) REFERENCES slots(id)
);
GO

INSERT INTO user_slots (userId, slotId) VALUES
(1, 1),
(2, 2),
(3, 1);


-- Bảng Mentor (mentors)
CREATE TABLE mentors (
    id INT PRIMARY KEY,
    userId INT,
    available_slots INT,
    specialty NVARCHAR(255),
    FOREIGN KEY (userId) REFERENCES users(id)
);
GO

INSERT INTO mentors (id, userId, available_slots, specialty) VALUES
(1, 2, 2, 'Driving License A'),
(2, 2, 2, 'Driving License B');


-- Bảng đăng ký học (registrations)
CREATE TABLE registrations (
    id INT PRIMARY KEY,
    userId INT,
    slotId INT,
    payment_status INT,
    FOREIGN KEY (userId) REFERENCES users(id),
    FOREIGN KEY (slotId) REFERENCES slots(id)
);


INSERT INTO registrations (id, userId, slotId, payment_status) VALUES
(1, 3, 2, 1),
(2, 3, 1, 1);


-- Bảng đánh giá Mentor (mentor_ratings)
CREATE TABLE mentor_ratings (
    id INT PRIMARY KEY,
    userId INT,
    mentorId INT,
    rating INT,
    feedback NVARCHAR(1000),
    FOREIGN KEY (userId) REFERENCES users(id),
    FOREIGN KEY (mentorId) REFERENCES users(id)
);

INSERT INTO mentor_ratings (id, userId, mentorId, rating, feedback) VALUES
(1, 3, 2, 4, 'Good mentor'),
(2, 3, 1, 3, 'Average mentor');


-- Bảng quản lý bài đăng (news_management)
CREATE TABLE news (
    id INT PRIMARY KEY,
    title NVARCHAR(255),
    content NVARCHAR(1000),
    post_date DATE
);

INSERT INTO news (id, title, content, post_date) VALUES
(1, 'New Course Announcement', 'We are pleased to announce a new driving course.', '2023-11-01'),
(2, 'Mentor Spotlight', 'Meet our top mentor of the month.', '2023-11-02');


-- Bảng khóa học (courses)
CREATE TABLE courses (
    id INT PRIMARY KEY,
    title NVARCHAR(255) NOT NULL,
    description NVARCHAR(1000),
    start_date DATE,
    end_date DATE
);

INSERT INTO courses (id, title, description, start_date, end_date) VALUES
(1, 'Driving Course A', 'Course for License A', '2023-11-01', '2023-11-15'),
(2, 'Driving Course B', 'Course for License B', '2023-11-01', '2023-11-20');


-- Bảng liên kết giữa khóa học, mentor và slot học (course_mentor_slots)
CREATE TABLE course_mentor_slots (
    courseId INT,
    mentorId INT,
    slotId INT,
    FOREIGN KEY (courseId) REFERENCES courses(id),
    FOREIGN KEY (mentorId) REFERENCES mentors(id),
    FOREIGN KEY (slotId) REFERENCES slots(id)
);


-- Thêm dữ liệu cho bảng course_mentor_slots
INSERT INTO course_mentor_slots (courseId, mentorId, slotId) VALUES
(1, 1, 1), -- Khóa học 1 được Mentor 1 hướng dẫn trong slot 1
(1, 1, 2), -- Khóa học 1 được Mentor 1 hướng dẫn trong slot 2
(2, 2, 1), -- Khóa học 2 được Mentor 2 hướng dẫn trong slot 1
(2, 2, 2); -- Khóa học 2 được Mentor 2 hướng dẫn trong slot 2

-- Bảng liên kết giữa người dùng và khóa học (user_courses)
CREATE TABLE user_courses (
    userId INT,
    courseId INT,
    FOREIGN KEY (userId) REFERENCES users(id),
    FOREIGN KEY (courseId) REFERENCES courses(id)
);


INSERT INTO user_courses (userId, courseId) VALUES
(1, 1),
(2, 1),
(3, 2);


