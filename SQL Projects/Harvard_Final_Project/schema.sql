-- Represents the user wanting to work out
CREATE TABLE `Users` (
    `user_id` INT AUTO_INCREMENT,
    `username` VARCHAR(50) NOT NULL UNIQUE,
    `age` INT,
    `gender` ENUM('Male', 'Female') NOT NULL,
    PRIMARY KEY(`user_id`)
);

-- Represents the workouts that can be completed by the user
CREATE TABLE `Workouts` (
    `workout_id` INT AUTO_INCREMENT,
    `name` VARCHAR(100) NOT NULL,
    `date` DATE NOT NULL,
    `duration` TIME NOT NULL,
    PRIMARY KEY(`workout_id`)
);

-- Represents the different exercises that can be done during a workout
CREATE TABLE `Exercises` (
    `exercise_id` INT AUTO_INCREMENT,
    `name` VARCHAR(100) NOT NULL,
    `category` ENUM('triceps', 'biceps', 'back', 'chest', 'legs', 'forearms', 'abs', 'shoulders') NOT NULL,
    `difficulty` INT CHECK (`difficulty` IN (1, 2, 3, 4, 5)),
    `workout_id` INT,
    PRIMARY KEY(`exercise_id`),
    FOREIGN KEY(`workout_id`) REFERENCES `Workouts`(`workout_id`)
);

-- Represents the progress made/to be made by the user
CREATE TABLE `Progress` (
    `progress_id` INT AUTO_INCREMENT,
    `user_id` INT,
    `workout_id` INT,
    `calories_burned` INT,
    PRIMARY KEY(`progress_id`),
    FOREIGN KEY(`user_id`) REFERENCES `Users`(`user_id`),
    FOREIGN KEY(`workout_id`) REFERENCES `Workouts`(`workout_id`)
);

-- Indexes
CREATE INDEX `username_search` ON `Users`(`username`);
CREATE INDEX `workout_search` ON `Workouts`(`workout_id`);
CREATE INDEX `exercise_search` ON `Exercises`(`exercise_id`);
CREATE INDEX `progress_search` ON `Progress`(`progress_id`);

-- Views
-- find a specific user's progress based on their username. 
CREATE VIEW specific_user AS
SELECT p.progress_id, u.*, p.calories_burned, p.workout_id FROM Progress p
JOIN Users u ON u.user_id = p.user_id
WHERE u.username = 'JemmaLouw42';

-- View to display workout details along with the exercises performed
CREATE VIEW workout_details AS
SELECT w.name AS workout_name, w.date, w.duration, e.name AS exercise_name, e.category, e.difficulty FROM Workouts w
JOIN Exercises e ON w.workout_id = e.workout_id;

-- View to summarize the total calories burned by each user
CREATE VIEW user_total_calories AS
SELECT u.username, SUM(p.calories_burned) AS total_calories_burned FROM Users u
JOIN Progress p ON u.user_id = p.user_id
GROUP BY u.user_id;
