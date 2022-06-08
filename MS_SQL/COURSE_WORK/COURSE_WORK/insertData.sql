set language english;
use [AMusic];
-- -- -- -- -- -- -- -- -- -- вставка исходных данных -- -- -- -- -- -- -- -- -- --

delete from FeaturedTracks;
delete from FeaturedAlbums;
delete from ArtistsInTracks;
delete from Tracks;
delete from Albums;
delete from Artists;
delete from Users;
delete from Roles;
delete from Countries;
delete from Genres;

insert into Genres values
('unknown'),
('Хип-хоп'),
('Поп'),
('Рок'),
('Рэп'),
('Dance'),
('Альтернатива'),
('R&B'),
('Lo-Fi'),
('Электронная'),
('Джаз'),
('Классика');

insert into Countries values
('unknown'),
('Аргентина'),
('Бразилия'),
('Великобритания'),
('Греция'),
('Дания'),
('Египет'),
('Индия'),
('Испания'),
('Италия'),
('Казахстан'),
('Канада'),
('Китай'),
('Латвия'),
('ОАЭ'),
('Польша'),
('Россия'),
('США'),
('Украина'),
('Франция'),
('Чехия'),
('Швеция'),
('Япония');

insert into Roles values
('main'),
('featured');

insert into Users (status, login, password, name, ID_country) values
(-1, 'neverket@gmail.com', '12345678', 'Aminov', 3);

insert into Artists (name, avatar_URL, ID_country) values
('Twenty One Pilots', null, 18),
('Imagine Dragons', null, 18),
('XXXTENTACION', null, 18),
('The Weeknd', null, 12),
('Oxxxymiron', null, 17),
('Powfu', null, 17),
('beabadoobee', null, 4),
('Marshmello', null, 18),
('Lil Peep', null, 22); 

-- [1] Blurryface --
insert into Albums (title, description, date_of_creation, url_LQ_cover, url_HQ_cover) values
('Blurryface', null, '2015-05-15', '/Resources/Albums/Blurryface/lq.jpeg', '/Resources/Albums/Blurryface/hq.jpg');
insert into Tracks (title, duration, url, lyrics, ID_album, id_in_album, ID_genre, count_of_listenings) values
('Heavydirtysoul', 234, 'Resources/Albums/Blurryface/twenty one pilots - Heavydirtysoul.mp3', null, 1, 1, 7, 330),
('Stressed Out', 202, 'Resources/Albums/Blurryface/Twenty One Pilots - Stressed Out.mp3'
,
'I wish I found some better sounds no one''s ever heard
I wish I had a better voice that sang some better words
I wish I found some chords in an order that is new
I wish I didn''t have to rhyme every time I sang
I was told, when I get older, all my fears would shrink
But now I''m insecure, and I care what people think

My name''s Blurryface and I care what you think
My name''s Blurryface and I care what you think

Wish we could turn back time to the good old days
When our momma sang us to sleep, but now we''re stressed out
(Oh) Wish we could turn back time (Oh) to the good old days (Oh)
When our momma sang us to sleep, but now we''re stressed out
We''re stressed out

Sometimes a certain smell will take me back to when I was young
How come I''m never able to identify where it''s comin'' from?
I''d make a candle out of it, if I ever found it
Try to sell it, never sell out of it, I''d probably only sell one
It''d be to my brother, ''cause we have the same nose
Same clothes, homegrown, a stone''s throw from a creek we used to roam
But it would remind us of when nothing really mattered
Out of student loans and treehouse homes, we all would take the latter

My-my-my name''s Blurryface and I care what you think
My name''s Blurryface and I care what you think

Wish we could turn back time to the good old days
When our momma sang us to sleep, but now we''re stressed out
(Oh) Wish we could turn back time (Oh) to the good old days (Oh)
When our momma sang us to sleep, but now we''re stressed out
[Bridge]
We used to play pretend, give each other different names
We would build a rocket ship an'' then we''d fly it far away
Used to dream of outer space, but now they''re laughin'' at our face
Sayin'', "Wake up, you need to make money!," yeah
We used to play pretend, give each other different names
We would build a rocket ship an'' then we''d fly it far away
Used to dream of outer space, but now they''re laughin'' at our face
Sayin'', "Wake up, you need to make money!," yeah

Wish we could turn back time to the good old days
When our momma sang us to sleep, but now we''re stressed out
(Oh) Wish we could turn back time (Oh) to the good old days (Oh)
When our momma sang us to sleep, but now we''re stressed out

We used to play pretend, used to play pretend, money
We used to play pretend, wake up, you need the money
Used to play pretend, used to play pretend, money
We used to play pretend, wake up, you need the money
Used to play pretend, give each other different names
We would build a rocket ship and then we''d fly it far away
Used to dream of outer space, but now they''re laughin'' at our face
Sayin'', "Wake up, you need to make money!," yeah'
,
1, 2, 7, 500),
('Ride', 214, 'Resources/Albums/Blurryface/Twenty One Pilots - Ride.mp3', null, 1, 3, 7, 190),
('Fairly Local', 207, 'Resources/Albums/Blurryface/twenty one pilots - Fairly Local.mp3', null, 1, 4, 7, 120),
('Tear in My Heart', 188, 'Resources/Albums/Blurryface/twenty one pilots - Tear in My Heart.mp3', null, 1, 5, 7, 350),
('Lane Boy', 253, 'Resources/Albums/Blurryface/twenty one pilots - Lane Boy.mp3', null, 1, 6, 7, 100),
('The Judge', 297, 'Resources/Albums/Blurryface/twenty one pilots - The Judge.mp3', null, 1, 7, 7, 100),
('Doubt', 191, 'Resources/Albums/Blurryface/twenty one pilots - Doubt.mp3', null, 1, 8, 7, 340),
('Polarize', 226, 'Resources/Albums/Blurryface/twenty one pilots - Polarize.mp3', null, 1, 9, 7, 80),
('We Don''t Believe What''s on TV', 177, 'Resources/Albums/Blurryface/twenty one pilots - We Don''t Believe What''s on TV.mp3', null, 1, 10, 7, 70),
('Message Man', 240, 'Resources/Albums/Blurryface/twenty one pilots - Message Man.mp3', null, 1, 11, 7, 100),
('Hometown', 235, 'Resources/Albums/Blurryface/twenty one pilots - Hometown.mp3', null, 1, 12, 7, 300),
('Not Today', 238, 'Resources/Albums/Blurryface/twenty one pilots - Not Today.mp3', null, 1, 13, 7, 110),
('Goner', 236, 'Resources/Albums/Blurryface/twenty one pilots - Goner.mp3', null, 1, 14, 7, 90);
insert into ArtistsInTracks (ID_artist, ID_track, ID_role) values
(1, 1, 1), (1, 2, 1), 
(1, 3, 1), (1, 4, 1), 
(1, 5, 1), (1, 6, 1), 
(1, 7, 1), (1, 8, 1), 
(1, 9, 1), (1, 10, 1), 
(1, 11, 1), (1, 12, 1), 
(1, 13, 1), (1, 14, 1);


-- [2] Trench --
insert into Albums (title, description, date_of_creation, url_LQ_cover, url_HQ_cover) values
('Trench', null, '2018-10-05', '/Resources/Albums/Trench/lq.png', '/Resources/Albums/Trench/hq.jpg');
insert into Tracks (title, duration, url, lyrics, ID_album, id_in_album, ID_genre, count_of_listenings) values
('Jumpsuit', 238, 'Resources/Albums/Trench/twenty one pilots - Jumpsuit.mp3', null, 2, 1, 7, 10),
('Levitate', 145, 'Resources/Albums/Trench/twenty one pilots - Levitate.mp3', null, 2, 2, 7, 100),
('Morph', 258, 'Resources/Albums/Trench/twenty one pilots - Morph.mp3', null, 2, 3, 7, 90),
('My Blood', 229, 'Resources/Albums/Trench/twenty one pilots - My Blood.mp3', null, 2, 4, 7, 70),
('Chlorine', 324, 'Resources/Albums/Trench/twenty one pilots - Chlorine.mp3', null, 2, 5, 7, 400),
('Smithereens', 177, 'Resources/Albums/Trench/twenty one pilots - Smithereens.mp3', null, 2, 6, 7, 70),
('Neon Gravestones', 240, 'Resources/Albums/Trench/twenty one pilots - Neon Gravestones.mp3', null, 2, 7, 7, 80),
('The Hype', 265, 'Resources/Albums/Trench/twenty one pilots - The Hype.mp3', null, 2, 8, 7, 90),
('Nico and the Niners', 227, 'Resources/Albums/Trench/twenty one pilots - Nico and the Niners.mp3', null, 2, 9, 7, 390),
('Cut My Lip', 282, 'Resources/Albums/Trench/twenty one pilots - Cut My Lip.mp3', null, 2, 10, 7, 80),
('Bandito', 331, 'Resources/Albums/Trench/twenty one pilots - Bandito.mp3', null, 2, 11, 7, 100),
('Pet Cheetah', 198, 'Resources/Albums/Trench/twenty one pilots - Pet Cheetah.mp3', null, 2, 12, 7, 80),
('Legend', 172, 'Resources/Albums/Trench/twenty one pilots - Legend.mp3', null, 2, 13, 7, 160),
('Leave the City', 280, 'Resources/Albums/Trench/twenty one pilots - Leave the City.mp3', null, 2, 14, 7, 70);
insert into ArtistsInTracks (ID_artist, ID_track, ID_role) values
(1, 15, 1), (1, 16, 1), 
(1, 17, 1), (1, 18, 1), 
(1, 19, 1), (1, 20, 1), 
(1, 21, 1), (1, 22, 1), 
(1, 23, 1), (1, 24, 1), 
(1, 25, 1), (1, 26, 1), 
(1, 27, 1), (1, 28, 1);


-- [3] Origins --
insert into Albums (title, description, date_of_creation, url_LQ_cover, url_HQ_cover) values
('Origins', null, '2018-11-09', '/Resources/Albums/Origins/hq.jpg', '/Resources/Albums/Origins/hq.jpg');
insert into Tracks (title, duration, url, lyrics, ID_album, id_in_album, ID_genre, count_of_listenings) values
('Natural', 189, 'Resources/Albums/Origins/0.mp3', null, 3, 1, 7, 300),
('Boomerang', 187, 'Resources/Albums/Origins/0.mp3', null, 3, 2, 7, 10),
('Machine', 181, 'Resources/Albums/Origins/0.mp3', null, 3, 3, 7, 90),
('Cool Out', 217, 'Resources/Albums/Origins/0.mp3', null, 3, 4, 7, 70),
('Bad Liar', 260, 'Resources/Albums/Origins/0.mp3', null, 3, 5, 7, 40),
('West Coast', 217, 'Resources/Albums/Origins/0.mp3', null, 3, 6, 7, 30),
('Zero (From the Original Motion Picture "Ralph Breaks The Internet")', 208, 'Resources/Albums/Origins/0.mp3', null, 3, 7, 7, 40),
('Bullet In A Gun', 204, 'Resources/Albums/Origins/0.mp3', null, 3, 8, 7, 90),
('Digital', 201, 'Resources/Albums/Origins/0.mp3', null, 3, 9, 7, 90),
('Only', 180, 'Resources/Albums/Origins/0.mp3', null, 3, 10, 7, 80),
('Stuck', 190, 'Resources/Albums/Origins/0.mp3', null, 3, 11, 7, 40),
('Love', 166, 'Resources/Albums/Origins/0.mp3', null, 3, 12, 7, 80),
('Birds', 219, 'Resources/Albums/Origins/0.mp3', null, 3, 13, 7, 160),
('Burn Out', 273, 'Resources/Albums/Origins/0.mp3', null, 3, 14, 7, 60),
('Real Life', 247, 'Resources/Albums/Origins/0.mp3', null, 3, 15, 7, 70);
insert into ArtistsInTracks (ID_artist, ID_track, ID_role) values
(2, 29, 1), (2, 30, 1), 
(2, 31, 1), (2, 32, 1), 
(2, 33, 1), (2, 34, 1), 
(2, 35, 1), (2, 36, 1), 
(2, 37, 1), (2, 38, 1), 
(2, 39, 1), (2, 40, 1), 
(2, 41, 1), (2, 42, 1), 
(2, 43, 1);


-- [4] Evolve --
insert into Albums (title, description, date_of_creation, url_LQ_cover, url_HQ_cover) values
('Evolve', null, '2017-06-23', '/Resources/Albums/Evolve/hq.jpg', '/Resources/Albums/Evolve/hq.jpg');
insert into Tracks (title, duration, url, lyrics, ID_album, id_in_album, ID_genre, count_of_listenings) values
('Next To Me', 229, 'Resources/Albums/Evolve/0.mp3', null, 4, 1, 7, 30),
('I Don’t Know Why', 190, 'Resources/Albums/Evolve/0.mp3', null, 4, 2, 7, 50),
('Whatever It Takes', 200, 'Resources/Albums/Evolve/0.mp3', null, 4, 3, 7, 290),
('Believer', 202, 'Resources/Albums/Evolve/0.mp3', null, 4, 4, 7, 370),
('Walking The Wire', 233, 'Resources/Albums/Evolve/0.mp3', null, 4, 5, 7, 40),
('Rise Up', 232, 'Resources/Albums/Evolve/0.mp3', null, 4, 6, 7, 100),
('I''ll Make It Up To You', 263, 'Resources/Albums/Evolve/0.mp3', null, 4, 7, 7, 40),
('Yesterday', 205, 'Resources/Albums/Evolve/0.mp3', null, 4, 8, 7, 90),
('Mouth Of The River', 222, 'Resources/Albums/Evolve/0.mp3', null, 4, 9, 7, 90),
('Thunder', 187, 'Resources/Albums/Evolve/0.mp3', null, 4, 10, 7, 310),
('Start Over', 186, 'Resources/Albums/Evolve/0.mp3', null, 4, 11, 7, 40),
('Dancing In The Dark', 234, 'Resources/Albums/Evolve/0.mp3', null, 4, 12, 7, 80);
insert into ArtistsInTracks (ID_artist, ID_track, ID_role) values
(2, 44, 1), (2, 45, 1), 
(2, 46, 1), (2, 47, 1), 
(2, 48, 1), (2, 49, 1), 
(2, 50, 1), (2, 51, 1), 
(2, 52, 1), (2, 53, 1), 
(2, 54, 1), (2, 55, 1);


-- [5] Look At Me! --
insert into Albums (title, description, date_of_creation, url_LQ_cover, url_HQ_cover) values
('Look At Me!', null, '2017-02-20', '/Resources/Albums/Look At Me!/hq.jpg', '/Resources/Albums/Look At Me!/hq.jpg');
insert into Tracks (title, duration, url, lyrics, ID_album, id_in_album, ID_genre, count_of_listenings) values
('Look At Me!', 126, 'Resources/Albums/Look At Me!/0.mp3', null, 5, 1, 5, 480);
insert into ArtistsInTracks (ID_artist, ID_track, ID_role) values
(3, 56, 1); 


-- [6] ? --
insert into Albums (title, description, date_of_creation, url_LQ_cover, url_HQ_cover) values
('?', null, '2018-03-16', '/Resources/Albums/{Question}/lq.jpg', '/Resources/Albums/{Question}/hq.jpg');
insert into Tracks (title, duration, url, lyrics, ID_album, id_in_album, ID_genre, count_of_listenings) values
('Introduction (instructions)', 117, 'Resources/Albums/{Question}/0.mp3', null, 6, 1, 2, 30),
('ALONE, PART 3', 109, 'Resources/Albums/{Question}/0.mp3', null, 6, 2, 2, 10),
('Moonlight', 135, 'Resources/Albums/{Question}/0.mp3', null, 6, 3, 2, 390),
('SAD!', 166, 'Resources/Albums/{Question}/0.mp3', null, 6, 4, 2, 520),
('the remedy for a broken heart (why am I so in love)', 160, 'Resources/Albums/{Question}/0.mp3', null, 6, 5, 2, 350),
('Floor 555', 93, 'Resources/Albums/{Question}/0.mp3', null, 6, 6, 2, 40),
('NUMB', 186, 'Resources/Albums/{Question}/0.mp3', null, 6, 7, 2, 80),
('infinity (888)', 176, 'Resources/Albums/{Question}/0.mp3', null, 6, 8, 2, 50),
('going down!', 115, 'Resources/Albums/{Question}/0.mp3', null, 6, 9, 2, 30),
('Pain = BESTFRIEND', 161, 'Resources/Albums/{Question}/0.mp3', null, 6, 10, 2, 80),
('$$$', 130, 'Resources/Albums/{Question}/0.mp3', null, 6, 11, 2, 40),
('love yourself (interlude)', 48, 'Resources/Albums/{Question}/0.mp3', null, 6, 12, 2, 80),
('SMASH!', 109, 'Resources/Albums/{Question}/0.mp3', null, 6, 13, 2, 60),
('I don''t even speak spanish lol', 192, 'Resources/Albums/{Question}/0.mp3', null, 6, 14, 2, 60),
('changes', 121, 'Resources/Albums/{Question}/0.mp3', null, 6, 15, 2, 380),
('Hope', 110, 'Resources/Albums/{Question}/0.mp3', null, 6, 16, 2, 360),
('schizophrenia', 80, 'Resources/Albums/{Question}/0.mp3', null, 6, 17, 2, 50),
('before I close my eyes', 99, 'Resources/Albums/{Question}/0.mp3', null, 6, 18, 2, 70);
insert into ArtistsInTracks (ID_artist, ID_track, ID_role) values
(3, 57, 1), (3, 58, 1), 
(3, 59, 1), (3, 60, 1), 
(3, 61, 1), (3, 62, 1), 
(3, 63, 1), (3, 64, 1), 
(3, 65, 1), (3, 66, 1), 
(3, 67, 1), (3, 68, 1), 
(3, 69, 1), (3, 70, 1),
(3, 71, 1), (3, 72, 1),
(3, 73, 1), (3, 74, 1);


-- [7] Heathens --
insert into Albums (title, description, date_of_creation, url_LQ_cover, url_HQ_cover) values
('Heathens', null, '2016-07-16', '/Resources/Albums/Heathens/hq.jpg', '/Resources/Albums/Heathens/hq.jpg');
insert into Tracks (title, duration, url, lyrics, ID_album, id_in_album, ID_genre, count_of_listenings) values
('Heathens', 195, 'Resources/Albums/Heathens/0.mp3', null, 7, 1, 4, 320);
insert into ArtistsInTracks (ID_artist, ID_track, ID_role) values
(1, 75, 1);

-- [8] Город под подошвой --
insert into Albums (title, description, date_of_creation, url_LQ_cover, url_HQ_cover) values
('Город под подошвой', null, '2015-09-21', '/Resources/Albums/Город под подошвой/hq.png', '/Resources/Albums/Город под подошвой/hq.png');
insert into Tracks (title, duration, url, lyrics, ID_album, id_in_album, ID_genre, count_of_listenings) values
('Город под подошвой', 195, 'Resources/Albums/Город под подошвой/0.mp3', null, 8, 1, 2, 300);
insert into ArtistsInTracks (ID_artist, ID_track, ID_role) values
(5, 76, 1);

-- [9] Blinding Lights --
insert into Albums (title, description, date_of_creation, url_LQ_cover, url_HQ_cover) values
('Blinding Lights', null, '2019-11-29', '/Resources/Albums/Blinding Lights/hq.jpg', '/Resources/Albums/Blinding Lights/hq.jpg');
insert into Tracks (title, duration, url, lyrics, ID_album, id_in_album, ID_genre, count_of_listenings) values
('Blinding Lights', 200, 'Resources/Albums/Blinding Lights/0.mp3', null, 9, 1, 8, 499);
insert into ArtistsInTracks (ID_artist, ID_track, ID_role) values
(4, 77, 1);

-- [10] death bed (coffee for your head) --
insert into Albums (title, description, date_of_creation, url_LQ_cover, url_HQ_cover) values
('death bed (coffee for your head)', null, '2020-02-08', '/Resources/Albums/death bed (coffee for your head)/hq.png', '/Resources/Albums/death bed (coffee for your head)/hq.png');
insert into Tracks (title, duration, url, lyrics, ID_album, id_in_album, ID_genre, count_of_listenings) values
('death bed (coffee for your head)', 200, 'Resources/Albums/death bed (coffee for your head)/0.mp3', null, 10, 1, 9, 250);
insert into ArtistsInTracks (ID_artist, ID_track, ID_role) values
(6, 78, 1), (7, 78, 2);

-- [11] Spotlight --
insert into Albums (title, description, date_of_creation, url_LQ_cover, url_HQ_cover) values
('Spotlight', null, '2018-01-12', '/Resources/Albums/Spotlight/hq.png', '/Resources/Albums/Spotlight/hq.png');
insert into Tracks (title, duration, url, lyrics, ID_album, id_in_album, ID_genre, count_of_listenings) values
('Spotlight', 178, 'Resources/Albums/Spotlight/0.mp3', null, 11, 1, 5, 350);
insert into ArtistsInTracks (ID_artist, ID_track, ID_role) values
(8, 79, 1), (9, 79, 1);

-- [12] Star Shopping --
insert into Albums (title, description, date_of_creation, url_LQ_cover, url_HQ_cover) values
('Star Shopping', null, '2019-04-19', '/Resources/Albums/Star Shopping/hq.png', '/Resources/Albums/Star Shopping/hq.png');
insert into Tracks (title, duration, url, lyrics, ID_album, id_in_album, ID_genre, count_of_listenings) values
('Star Shopping', 142, 'Resources/Albums/Star Shopping/0.mp3', null, 12, 1, 2, 450);
insert into ArtistsInTracks (ID_artist, ID_track, ID_role) values
(9, 80, 1);


insert into FeaturedAlbums (ID_album, ID_user, when_added) values
(1, 1, '2022-04-15 22:58:36'),
(2, 1, '2022-04-15 22:59:01'),
(4, 1, '2022-04-30 15:30:05'),
(5, 1, '2022-04-30 15:57:50'),
(6, 1, '2022-04-30 16:36:05'),
(11, 1, '2022-05-7 20:34:16');

insert into FeaturedTracks (ID_track, ID_user, when_added, count_of_listenings) values
(1, 1, '2022-04-15 22:58:59', 13), --1
(2, 1, '2022-04-15 23:01:01', 21),
(5, 1, '2022-04-15 23:04:21', 15),
(8, 1, '2022-04-15 23:07:33', 18),
(12, 1, '2022-04-15 23:09:48', 11),
(16, 1, '2022-04-15 23:13:12', 9), --2
(17, 1, '2022-04-15 23:16:34', 25),
(19, 1, '2022-04-15 23:20:43', 15),
(23, 1, '2022-04-15 23:25:52', 23),
(27, 1, '2022-04-15 23:28:35', 14),
(29, 1, '2022-04-30 14:57:15', 10), --3
(46, 1, '2022-04-30 15:27:05', 20), --4
(47, 1, '2022-04-30 15:31:15', 11),
(53, 1, '2022-04-30 15:34:11', 17),
(56, 1, '2022-04-30 15:57:35', 23), --5
(59, 1, '2022-04-30 16:04:34', 16), --6
(60, 1, '2022-04-30 16:07:26', 25),
(61, 1, '2022-04-30 16:12:51', 17),
(71, 1, '2022-04-30 16:15:01', 22),
(72, 1, '2022-04-30 16:20:33', 23),
(75, 1, '2022-05-7 20:21:21', 20), --7
(76, 1, '2022-05-7 20:24:26', 20), --8
(77, 1, '2022-05-7 20:27:20', 25), --9
(78, 1, '2022-05-7 20:31:20', 26), --10
(79, 1, '2022-05-7 20:34:10', 30), --11
(80, 1, '2022-05-7 20:38:10', 38); --12

