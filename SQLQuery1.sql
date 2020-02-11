UPDATE  dbo.Items   
SET  InternalImage=(SELECT * FROM OPENROWSET(BULK N'D:\github\ISAD251-CW-Douglas-Pub\DougPub2\Content\img\pork-scratchings.jpg', SINGLE_BLOB) AS InternalImage)
WHERE ID=1 ;

UPDATE  dbo.Items   
SET  InternalImage=(SELECT * FROM OPENROWSET(BULK N'D:\github\ISAD251-CW-Douglas-Pub\DougPub2\Content\img\scotch-egg.jpg', SINGLE_BLOB) AS InternalImage)
WHERE ID=2 ;

UPDATE  dbo.Items   
SET  InternalImage=(SELECT * FROM OPENROWSET(BULK N'D:\github\ISAD251-CW-Douglas-Pub\DougPub2\Content\img\soup.jpg', SINGLE_BLOB) AS InternalImage)
WHERE ID=3 ;

UPDATE  dbo.Items   
SET  InternalImage=(SELECT * FROM OPENROWSET(BULK N'D:\github\ISAD251-CW-Douglas-Pub\DougPub2\Content\img\pate-on-toast.jpg', SINGLE_BLOB) AS InternalImage)
WHERE ID=4 ;

UPDATE  dbo.Items   
SET  InternalImage=(SELECT * FROM OPENROWSET(BULK N'D:\github\ISAD251-CW-Douglas-Pub\DougPub2\Content\img\potted-shrimps.jpg', SINGLE_BLOB) AS InternalImage)
WHERE ID=5 ;

UPDATE  dbo.Items   
SET  InternalImage=(SELECT * FROM OPENROWSET(BULK N'D:\github\ISAD251-CW-Douglas-Pub\DougPub2\Content\img\whitebait.jpg', SINGLE_BLOB) AS InternalImage)
WHERE ID=6 ;

UPDATE  dbo.Items   
SET  InternalImage=(SELECT * FROM OPENROWSET(BULK N'D:\github\ISAD251-CW-Douglas-Pub\DougPub2\Content\img\all-day-breakfast.jpg', SINGLE_BLOB) AS InternalImage)
WHERE ID=7 ;

UPDATE  dbo.Items   
SET  InternalImage=(SELECT * FROM OPENROWSET(BULK N'D:\github\ISAD251-CW-Douglas-Pub\DougPub2\Content\img\fish-and-chips-2.jpg', SINGLE_BLOB) AS InternalImage)
WHERE ID=8 ;

UPDATE  dbo.Items   
SET  InternalImage=(SELECT * FROM OPENROWSET(BULK N'D:\github\ISAD251-CW-Douglas-Pub\DougPub2\Content\img\scampi-chips.jpg', SINGLE_BLOB) AS InternalImage)
WHERE ID=9 ;

UPDATE  dbo.Items   
SET  InternalImage=(SELECT * FROM OPENROWSET(BULK N'D:\github\ISAD251-CW-Douglas-Pub\DougPub2\Content\img\bangers-and-mash-1.jpg', SINGLE_BLOB) AS InternalImage)
WHERE ID=10 ;

UPDATE  dbo.Items   
SET  InternalImage=(SELECT * FROM OPENROWSET(BULK N'D:\github\ISAD251-CW-Douglas-Pub\DougPub2\Content\img\pork-belly-and-mash.jpg', SINGLE_BLOB) AS InternalImage)
WHERE ID=11 ;

UPDATE  dbo.Items   
SET  InternalImage=(SELECT * FROM OPENROWSET(BULK N'D:\github\ISAD251-CW-Douglas-Pub\DougPub2\Content\img\pie-mash.jpg', SINGLE_BLOB) AS InternalImage)
WHERE ID=12 ;

UPDATE  dbo.Items   
SET  InternalImage=(SELECT * FROM OPENROWSET(BULK N'D:\github\ISAD251-CW-Douglas-Pub\DougPub2\Content\img\liver-bacon.jpg', SINGLE_BLOB) AS InternalImage)
WHERE ID=13 ;

UPDATE  dbo.Items   
SET  InternalImage=(SELECT * FROM OPENROWSET(BULK N'D:\github\ISAD251-CW-Douglas-Pub\DougPub2\Content\img\burger-and-chips.jpg', SINGLE_BLOB) AS InternalImage)
WHERE ID=14 ;

UPDATE  dbo.Items   
SET  InternalImage=(SELECT * FROM OPENROWSET(BULK N'D:\github\ISAD251-CW-Douglas-Pub\DougPub2\Content\img\steak-and-chips-british-dinners.jpg', SINGLE_BLOB) AS InternalImage)
WHERE ID=15 ;

UPDATE  dbo.Items   
SET  InternalImage=(SELECT * FROM OPENROWSET(BULK N'D:\github\ISAD251-CW-Douglas-Pub\DougPub2\Content\img\ice-cream-sundae-pub-dessert.jpg', SINGLE_BLOB) AS InternalImage)
WHERE ID=16 ;

UPDATE  dbo.Items   
SET  InternalImage=(SELECT * FROM OPENROWSET(BULK N'D:\github\ISAD251-CW-Douglas-Pub\DougPub2\Content\img\sticky-toffee-pudding.jpg', SINGLE_BLOB) AS InternalImage)
WHERE ID=17 ;

UPDATE  dbo.Items   
SET  InternalImage=(SELECT * FROM OPENROWSET(BULK N'D:\github\ISAD251-CW-Douglas-Pub\DougPub2\Content\img\apple-crumble.jpg', SINGLE_BLOB) AS InternalImage)
WHERE ID=18 ;

UPDATE  dbo.Items   
SET  InternalImage=(SELECT * FROM OPENROWSET(BULK N'D:\github\ISAD251-CW-Douglas-Pub\DougPub2\Content\img\chocolate-fudge-cake.jpg', SINGLE_BLOB) AS InternalImage)
WHERE ID=19 ;

UPDATE  dbo.Items   
SET  InternalImage=(SELECT * FROM OPENROWSET(BULK N'D:\github\ISAD251-CW-Douglas-Pub\DougPub2\Content\img\cheese-board.jpg', SINGLE_BLOB) AS InternalImage)
WHERE ID=20 ;

UPDATE  dbo.Items   
SET  InternalImage=(SELECT * FROM OPENROWSET(BULK N'D:\github\ISAD251-CW-Douglas-Pub\DougPub2\Content\img\guinness-stout.jpg', SINGLE_BLOB) AS InternalImage)
WHERE ID=21 ;

UPDATE  dbo.Items   
SET  InternalImage=(SELECT * FROM OPENROWSET(BULK N'D:\github\ISAD251-CW-Douglas-Pub\DougPub2\Content\img\OHARAS-IRISH-RED.jpg', SINGLE_BLOB) AS InternalImage)
WHERE ID=22 ;

UPDATE  dbo.Items   
SET  InternalImage=(SELECT * FROM OPENROWSET(BULK N'D:\github\ISAD251-CW-Douglas-Pub\DougPub2\Content\img\MAGNERS-APPLE-CIDER.jpg', SINGLE_BLOB) AS InternalImage)
WHERE ID=23 ;

UPDATE  dbo.Items   
SET  InternalImage=(SELECT * FROM OPENROWSET(BULK N'D:\github\ISAD251-CW-Douglas-Pub\DougPub2\Content\img\ABSOLUT-VODKA.jpg', SINGLE_BLOB) AS InternalImage)
WHERE ID=24 ;

UPDATE  dbo.Items   
SET  InternalImage=(SELECT * FROM OPENROWSET(BULK N'D:\github\ISAD251-CW-Douglas-Pub\DougPub2\Content\img\MOJITOS.jpg', SINGLE_BLOB) AS InternalImage)
WHERE ID=25 ;

UPDATE  dbo.Items   
SET  InternalImage=(SELECT * FROM OPENROWSET(BULK N'D:\github\ISAD251-CW-Douglas-Pub\DougPub2\Content\img\BLACK-RUSSIAN.jpg', SINGLE_BLOB) AS InternalImage)
WHERE ID=26 ;

UPDATE  dbo.Items   
SET  InternalImage=(SELECT * FROM OPENROWSET(BULK N'D:\github\ISAD251-CW-Douglas-Pub\DougPub2\Content\img\SLOW-COMFORTABLE-SCREW.jpg', SINGLE_BLOB) AS InternalImage)
WHERE ID=27 ;

UPDATE  dbo.Items   
SET  InternalImage=(SELECT * FROM OPENROWSET(BULK N'D:\github\ISAD251-CW-Douglas-Pub\DougPub2\Content\img\FRUIT-PUNCH.jpg', SINGLE_BLOB) AS InternalImage)
WHERE ID=28 ;

UPDATE  dbo.Items   
SET  InternalImage=(SELECT * FROM OPENROWSET(BULK N'D:\github\ISAD251-CW-Douglas-Pub\DougPub2\Content\img\SHIRLEY-TEMPLE.jpg', SINGLE_BLOB) AS InternalImage)
WHERE ID=29 ;

UPDATE  dbo.Items   
SET  InternalImage=(SELECT * FROM OPENROWSET(BULK N'D:\github\ISAD251-CW-Douglas-Pub\DougPub2\Content\img\coke.jpg', SINGLE_BLOB) AS InternalImage)
WHERE ID=30 ;