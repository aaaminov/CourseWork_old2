--create database [AMusic];
use [AMusic];
-- -- -- -- -- -- -- -- -- -- таблицы -- -- -- -- -- -- -- -- -- --

drop table if exists SupportLog;
drop table if exists FeaturedTracks;
drop table if exists FeaturedAlbums;
	drop table if exists ArtistsInTracks;
	drop table if exists Tracks;
	drop table if exists Covers;
	drop table if exists Albums;
drop table if exists Artists;
drop table if exists Users;
	drop table if exists Roles;
	drop table if exists Countries;
	drop table if exists Genres;


drop table if exists Genres;
create table Genres (
	ID_genre int not null identity(1, 1) constraint PK_genres primary key,
	title nvarchar(64) not null
);
--insert into Genres values ('unknown');

drop table if exists Countries;
create table Countries (
	ID_country int not null identity(1, 1) constraint PK_countries primary key,
	name nvarchar(100) not null
);
--insert into Countries values ('unknown');

drop table if exists Roles;
create table Roles (
	ID_role int not null identity(1, 1) constraint PK_role primary key,
	name nvarchar(32) not null
);
--insert into Roles values ('main'), ('featured');



drop table if exists Users;
create table Users (
	ID_user int not null identity(1, 1) constraint PK_users primary key,
	status int default 0,
	login nvarchar(max) not null,
	password nvarchar(max) not null,
	name nvarchar(150) not null,
	avatar_URL nvarchar(max) default 'Resources\Assests\default_user.png',
	ID_country int not null constraint FK_Users_ID_country foreign key(ID_country) references Countries(ID_country)
);

drop table if exists Artists;
create table Artists (
	ID_artist int not null identity(1, 1) constraint PK_artists primary key,
	name nvarchar(150) not null,
	avatar_URL nvarchar(max) default 'Resources\Assests\default_artist.png',
	ID_country int not null constraint FK_Artists_ID_country foreign key(ID_country) references Countries(ID_country)
);



drop table if exists Albums;
create table Albums (
	ID_album int not null identity(1, 1) constraint PK_album primary key,
	title nvarchar(150) not null,
	description nvarchar(max) default null,
	date_of_creation date default '2000/01/01',
	url_LQ_cover nvarchar(max) default 'Resources\Assests\default_lq_cover.png',
	url_HQ_cover nvarchar(max) default 'Resources\Assests\default_hq_cover.png',
);

--drop table if exists Covers;
--create table Covers (
--	ID_cover int not null identity(1, 1) constraint PK_cover primary key,
--	ID_album int not null constraint FK_Covers_ID_album foreign key(ID_album) references Albums(ID_album),
--	url_LQ_cover nvarchar(max) default 'covers\LQ\default.png',
--	url_HQ_cover nvarchar(max) default 'covers\HQ\default.png',
--);

drop table if exists Tracks;
create table Tracks (
	ID_track int not null identity(1, 1) constraint PK_track primary key,
	title nvarchar(150) not null,
	duration int not null,
	url nvarchar(max) not null,
	lyrics nvarchar(max),
	ID_album int not null constraint FK_Tracks_ID_album foreign key(ID_album) references Albums(ID_album),
	id_in_album int default 1,
	ID_genre int not null constraint FK_Tracks_ID_genre foreign key(ID_genre) references Genres(ID_genre),
	count_of_listenings int default 0
);

drop table if exists ArtistsInTracks;
create table ArtistsInTracks (
	ID_artist int not null constraint FK_AIT_ID_artist foreign key(ID_artist) references Artists(ID_artist),
	ID_track int not null constraint FK_AIT_ID_track foreign key(ID_track) references Tracks(ID_track),
	ID_role int not null constraint FK_AIT_ID_role foreign key(ID_role) references Roles(ID_role)
);



drop table if exists FeaturedAlbums;
create table FeaturedAlbums (
	ID_album int not null constraint FK_FA_ID_album foreign key(ID_album) references Albums(ID_album),
	ID_user int not null constraint FK_FA_ID_user foreign key(ID_user) references Users(ID_user),
	when_added datetime,
	-- how_many_times_listened int default 0
	-- хз нужен ли он
);

drop table if exists FeaturedTracks;
create table FeaturedTracks (
	ID_track int not null constraint FK_FT_ID_album foreign key(ID_track) references Tracks(ID_track),
	ID_user int not null constraint FK_FT_ID_user foreign key(ID_user) references Users(ID_user),
	when_added datetime,
	count_of_listenings int default 0
);

drop table if exists SupportLog;
create table SupportLog (
	ID_log int not null identity(1, 1) constraint PK_log primary key,
	ID_user int not null constraint FK_SL_ID_user foreign key(ID_user) references Users(ID_user),
	when_added datetime,
	content nvarchar(max)
);
