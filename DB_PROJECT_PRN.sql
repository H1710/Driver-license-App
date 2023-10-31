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

-- Bảng kiểm tra (test)
CREATE TABLE tests (
    id INT PRIMARY KEY,
    title NVARCHAR(255) NOT NULL
);
GO

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

-- Bảng hồ sơ (profile)
CREATE TABLE profiles (
    userId INT PRIMARY KEY,
    reg_date DATE,
    FOREIGN KEY (userId) REFERENCES users(id)
);
GO

-- Bảng slot (slots)
CREATE TABLE slots (
    id INT PRIMARY KEY,
    [date] DATE NOT NULL,
    start_time TIME,
    end_time TIME
);
GO

-- Bảng câu hỏi trong bài kiểm tra (test_question)
CREATE TABLE test_questions (
    id INT PRIMARY KEY,
    questionId INT,
    testId INT,
    FOREIGN KEY (questionId) REFERENCES questions(id),
    FOREIGN KEY (testId) REFERENCES tests(id)
);
GO

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

-- Bảng người dùng và slot (user_slots)
CREATE TABLE user_slots (
    userId INT,
    slotId INT,
    PRIMARY KEY (userId, slotId),
    FOREIGN KEY (userId) REFERENCES users(id),
    FOREIGN KEY (slotId) REFERENCES slots(id)
);
GO

-- Bảng Mentor (mentors)
CREATE TABLE mentors (
    id INT PRIMARY KEY,
    userId INT,
    available_slots INT,
    specialty NVARCHAR(255),
    FOREIGN KEY (userId) REFERENCES users(id)
);
GO

-- Bảng đăng ký học (registrations)
CREATE TABLE registrations (
    id INT PRIMARY KEY,
    userId INT,
    slotId INT,
    payment_status INT,
    FOREIGN KEY (userId) REFERENCES users(id),
    FOREIGN KEY (slotId) REFERENCES slots(id)
);

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

-- Bảng quản lý bài đăng (news_management)
CREATE TABLE news (
    id INT PRIMARY KEY,
    title NVARCHAR(255),
    content NVARCHAR(1000),
    post_date DATE
);

-- Bảng khóa học (courses)
CREATE TABLE courses (
    id INT PRIMARY KEY,
    title NVARCHAR(255) NOT NULL,
    description NVARCHAR(1000),
    start_date DATE,
    end_date DATE
);

-- Bảng liên kết giữa khóa học, mentor và slot học (course_mentor_slots)
CREATE TABLE course_mentor_slots (
    courseId INT,
    mentorId INT,
    slotId INT,
    FOREIGN KEY (courseId) REFERENCES courses(id),
    FOREIGN KEY (mentorId) REFERENCES mentors(id),
    FOREIGN KEY (slotId) REFERENCES slots(id)
);

-- Bảng liên kết giữa người dùng và khóa học (user_courses)
CREATE TABLE user_courses (
    userId INT,
    courseId INT,
    FOREIGN KEY (userId) REFERENCES users(id),
    FOREIGN KEY (courseId) REFERENCES courses(id)
);

