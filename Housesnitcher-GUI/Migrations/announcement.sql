CREATE TABLE announcements (
	title VARCHAR(50) PRIMARY KEY,
	descr VARCHAR(256)NOT NULL DEFAULT 'No description provided.',
	announcer VARCHAR(50) NOT NULL,
	announced VARCHAR(50) NOT NULL,
	referred_date VARCHAR(50) NOT NULL
)