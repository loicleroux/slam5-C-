CREATE TABLE utilisateur (id int(10) AUTO_INCREMENT PRIMARY KEY,
nom varchar(255),
prenom varchar(255),
login varchar(255) unique not null,
mdp varchar(255) not null,
mail varchar(255) unique not null);

http://blog.mounier-logiciels.fr/comment-creer-une-connection-mysql-local-en-CSharp.html