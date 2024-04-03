CREATE TABLE Users
(
    UserId INT IDENTITY(1,1) PRIMARY KEY,
    FullName VARCHAR(255) NOT NULL,
    Email VARCHAR(255) UNIQUE NOT NULL,
    NIC VARCHAR(20) UNIQUE NOT NULL,
    PasswordHash VARCHAR(255) NOT NULL
);

-- Buses Table
CREATE TABLE Buses
(
    BusId INT IDENTITY(1,1) PRIMARY KEY,
    LicensePlate VARCHAR(50) NOT NULL,
    Capacity INT NOT NULL
);

-- Routes Table
CREATE TABLE Routes
(
    RouteId INT IDENTITY(1,1) PRIMARY KEY,
    Origin VARCHAR(255) NOT NULL,
    Destination VARCHAR(255) NOT NULL,
    DepartureTime DATETIME NOT NULL,
    ArrivalTime DATETIME NOT NULL,
    BusId INT,
    FOREIGN KEY (BusId) REFERENCES Buses(BusId)
);

-- Seats Table
CREATE TABLE Seats
(
    SeatId INT IDENTITY(1,1) PRIMARY KEY,
    SeatNumber VARCHAR(10) NOT NULL,
    BusId INT,
    IsAvailable BIT DEFAULT 1,
    FOREIGN KEY (BusId) REFERENCES Buses(BusId)
);

-- Bookings Table
CREATE TABLE bookings
(
    BookingId INT IDENTITY(1,1) PRIMARY KEY,
    UserId INT NOT NULL,
    NumOfSeats INT NOT NULL,
    RouteId INT NOT NULL,
    BookingTime DATETIME NOT NULL,
);