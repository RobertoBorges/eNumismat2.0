﻿-- Table CONTACTS
CREATE TABLE IF NOT EXISTS [contacts](
  [id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, 
  [name] TEXT(99) NOT NULL, 
  [gender] TEXT(15));

-- Table GENDER
CREATE TABLE IF NOT EXISTS [gender](
  [gender] TEXT(15) PRIMARY KEY NOT NULL UNIQUE, 
  [symbol] TEXT(1));

-- Table LABELS
CREATE TABLE IF NOT EXISTS [labels](
  [id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, 
  [labelname] TEXT(99) NOT NULL, 
  [labelcolor] TEXT(15));

-- Table LABELCOLLECTION FOR CONTACTS
CREATE TABLE IF NOT EXISTS [labelstocontact](
  [label_id] INTEGER NOT NULL,
  [contacts_id] INTEGER NOT NULL,
  PRIMARY KEY (label_id, contacts_id));

-- Table TAGS
CREATE TABLE IF NOT EXISTS [tags](
  [tag] TEXT(30) PRIMARY KEY UNIQUE NOT NULL);

-- Insert Values into TAGS
INSERT INTO [tags] (
  [tag])
VALUES
('Test'),
('Noch ein Test Tag'),
('und noch einer'),
('Nur mal so');

-- Table TAGCOLLECTION FOR CONTACTS
CREATE TABLE IF NOT EXISTS [tagstocontact](
  [tag] TEXT(30) NOT NULL,
  [contacts_id] INTEGER NOT NULL,
  PRIMARY KEY (tag, contacts_id));

-- Table POSTAL CODES
CREATE TABLE IF NOT EXISTS "postalcode"([postalcode] TEXT(10) PRIMARY KEY NOT NULL UNIQUE);

-- Table STATES
CREATE TABLE IF NOT EXISTS "state"(
  [id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, 
  [state] TEXT(99) NOT NULL);

-- Table CITIES
CREATE TABLE IF NOT EXISTS "city"(
  [id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, 
  [city] TEXT(99) NOT NULL);

-- Table COUNTRIES
CREATE TABLE IF NOT EXISTS [country](
  [id] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, 
  [name] TEXT(50) NOT NULL, 
  [ISO_2] TEXT(2) NOT NULL, 
  [ISO_3] TEXT(3), 
  [de] TEXT(50), 
  [es] TEXT(50), 
  [fr] TEXT(50),
  [ro] TEXT(50),
  [ar] TEXT(50));