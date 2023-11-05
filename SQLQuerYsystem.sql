Create database AppointmentSystem

 use AppointmentSystem

  Create table FitnessTrainingSessions(
  Sesssion_id INT PRIMARY KEY, 
  date DATE,
  time TIME,
  instructor_id INT,
  locationn VARCHAR(100),
  duration INT,
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
  participants_id INT PRIMARY KEY,
  name_par VARCHAR(100),
  contact_info VARCHAR(100)
  );

  Create table InstructorAvailability (
    availability_id INT PRIMARY KEY,
    instructor_id INT,
    day_of_week VARCHAR(15),
    start_time TIME,
    end_time TIME
  );

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


