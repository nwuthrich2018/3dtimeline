--How to access Database in shell
\sql
\connect root@localhost
team7

-- Creates a new table named AllData that holds all artifacts with the tag "Coming of Age"
CREATE VIEW AllData AS
SELECT DISTINCT e.record_id, e.element_id, e.text, f.filename
FROM omeka_element_texts e, omeka_files f
WHERE e.record_id = f.item_id AND e.record_id = ANY (SELECT record_id FROM omeka_tags t JOIN omeka_records_tags r ON t.id = r.tag_id WHERE t.id = 1044); -- t.id = 1044 refers to tag coming of age

--Creates an empty table to hold data for each artifact
CREATE TABLE Artifacts (
	Record_id int,
	Title varchar(50),
	Date_id varchar(50),
	Source varchar(50),
	Type_of varchar(100),
	format_type varchar(50);
  URL varchar(50);
	PRIMARY KEY (Record_id)
);

--Inserts all Record_id's into artifacts. Each record_ird refers to one item
INSERT INTO artifacts(Record_id)
SELECT DISTINCT record_id
FROM alldata;

--Adds the Titles into table Artifacts based on record_id
UPDATE artifacts a, alldata d SET a.title = d.text
WHERE a.record_id = d.record_id AND d.element_id = 50; -- id 50 refers to title

--Adds the dates into table Artifacts based on record_id
UPDATE artifacts a, alldata d SET a.Date_id = d.text
WHERE a.record_id = d.record_id AND d.element_id = 40;

--Adds the Source into table Artifacts based on record_id
UPDATE artifacts a, alldata d SET a.Source = d.text
WHERE a.record_id = d.record_id AND d.element_id = 48;

--Adds the type into table Artifacts based on record_id
UPDATE artifacts a, alldata d SET a.Type_of = d.text
WHERE a.record_id = d.record_id AND d.element_id = 51;

--Adds the format into table Artifacts based on record_id
UPDATE artifacts a, alldata d SET a.format_type = d.text
WHERE a.record_id = d.record_id AND d.element_id = 42;

--Adds the URL's into table Artifacts 
UPDATE artifacts a, alldata d SET a.url = d.filename
WHERE a.record_id = d.record_id;

