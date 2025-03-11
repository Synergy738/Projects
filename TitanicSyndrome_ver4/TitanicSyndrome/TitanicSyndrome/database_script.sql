

            CREATE TABLE IF NOT EXISTS Users (
                id INT PRIMARY KEY AUTO_INCREMENT,
                name NVARCHAR(100),
                age INT,
                email NVARCHAR(100), 
                gender BIT,
                cell_num BIGINT,
                job_title VARCHAR(100)
            );

            INSERT INTO Users (name, age, email, gender, cell_num, job_title) 
            VALUES ('{person.name}', '{person.age}', '{person.email}', '{(person.gender ? 1 : 0)}', '{person.cell_num}', '{person.job}');
            