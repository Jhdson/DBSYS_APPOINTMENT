Create database AppointmentSystem

 use AppointmentSystem

  Create table FitnessTrainingSessions(
  Sesssion_id INT PRIMARY KEY, 
  date DATE,
  time TIME,
  instructor_id INT,
  locationn VARCHAR(100),
  duration_minutes INT,
  activity_type VARCHAR(100),
  notes VARCHAR(1000)
  );

  Create table Instructor(
  instructor_id INT PRIMARY KEY,
  name_ins VARCHAR(100),
  expertise VARCHAR(100),
  contact_info VARCHAR(100)
  );

  Create table Participants(
 participant_id INT PRIMARY KEY,
    first_name VARCHAR(50),
    last_name VARCHAR(50),
    middle_name VARCHAR(50),
    contact_number VARCHAR(20), 
    address1 VARCHAR(100),
    city VARCHAR(50),
    state VARCHAR(50),
    postal_code VARCHAR(20)
  );

  CREATE TABLE FitnessSchedule (
    schedule_id INT PRIMARY KEY,
    instructor_id INT,
    session_id INT,
    day_of_week VARCHAR(15),
    start_time TIME,
    end_time TIME,
    location VARCHAR(100),
	)

  Create table PaymentTransactions (
    transaction_id INT PRIMARY KEY,
    session_id INT,
    participant_id INT,
    payment_date DATE,
    amount DECIMAL(10, 2),
    payment_method VARCHAR(50)
  );

  CREATE TABLE ParticipantFeedback (
    feedback_id INT PRIMARY KEY,
    session_id INT,
    participant_id INT,
    rating INT,
    comments VARCHAR(1000)
  );


