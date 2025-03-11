-- Adding new users to the Users table (auto-incrementing user_id)
INSERT INTO Users (username, age, gender)
VALUES 
('JemmaLouw42', 19, 'Female'),
('dennisblu.exe', 20, 'Male'),
('JohnDoe', 35, 'Male'),
('User4', 40, 'Female'),
('User5', 45, 'Male'),
('User6', 50, 'Female'),
('User7', 55, 'Male'),
('User8', 60, 'Female'),
('User9', 65, 'Male'),
('User10', 70, 'Female'),
('User11', 75, 'Male'),
('User12', 80, 'Female'),
('User13', 85, 'Male'),
('User14', 90, 'Female'),
('User15', 95, 'Male');

-- Inserting workouts without specifying the auto-incrementing workout_id
INSERT INTO Workouts (name, date, duration)
VALUES 
('Push day', '2024-10-07', '01:30:00'), 
('Leg day', '2024-10-08', '01:15:00'),
('Pull day', '2024-10-09', '01:05:00'),
('Arms', '2024-10-10', '00:50:00'),
('Cardio & Core', '2024-10-11', '00:40:00');  

-- Adding exercises linked directly to valid workout_id
INSERT INTO Exercises (name, category, difficulty, workout_id)
VALUES 
('Bicep Curl', 'biceps', 2, 4),
('Tricep Pushdown', 'triceps', 3, 1),
('Bench Press', 'chest', 4, 1),
('Deadlift', 'back', 5, 3),
('Squats', 'legs', 4, 2),
('Wrist Curl', 'forearms', 1, 4),
('Crunches', 'abs', 2, 5),
('Shoulder Press', 'shoulders', 3, 4),
('Hammer Curl', 'biceps', 2, 3),
('Skullcrusher', 'triceps', 3, 4),
('Incline Bench Press', 'chest', 4, 1),
('Bent Over Row', 'back', 5, 3),
('Lunges', 'legs', 3, 2),
('Reverse Wrist Curl', 'forearms', 1, 4),
('Plank', 'abs', 2, 5);

-- Recording progress for a user in a specific workout in the progress table
INSERT INTO Progress (user_id, workout_id, calories_burned)
VALUES 
(1, 1, 250),
(2, 2, 200),
(3, 3, 200),
(4, 4, 400),
(5, 5, 350),
(3, 4, 350),
(4, 2, 700),
(1, 5, 400),
(2, 3, 400),
(5, 1, 250),
(2, 5, 450),
(5, 3, 200),
(5, 4, 300),
(5, 2, 400),
(3, 5, 500);


-- QUERIES
-- Find a specific user's progress if provided the user's username
SELECT * FROM specific_user;

-- Displaying workout details along with the exercises performed 
SELECT * FROM workout_details;

-- displays the total calories burned by each user
SELECT * FROM user_total_calories;
