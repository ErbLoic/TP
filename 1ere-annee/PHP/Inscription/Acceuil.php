<html>
    <head>
        <title>Inscription</title>
        <meta charset="utf-8">
        <link href="style.css" rel="stylesheet" >
    </head>
    <body>    
    <div class="form">
      
      <?php 
      session_start();
      $pseudo=$_SESSION["pseudo"] ?? "";
      echo'<div class="title">Bienvenue </div>';
      $bdd= new PDO('mysql:host=127.0.0.1;dbname=test','root','');
      $sql = $bdd -> prepare("SELECT * FROM client where pseudo=?");
      $sql -> execute(array($pseudo));
      $client = $sql-> fetchALL(PDO::FETCH_OBJ);
      echo "<div class='subtitle' >Prénom:".$client[0]->prenom."<br>Nom:".$client[0]->nom."<br>Email:".$client[0]->email."<br> Date d'incription:".$client[0]->date;
      ?>
      <form action="" method="post">
        <div class="input-container ic1">
        <input type="text" name="search" id="search" placeholder=" " class="input">
        <div class="cut cut-short"></div>
        <label for="search" class="placeholder">Recherche</label>
      </div>
</div>
        <input type="submit" value="Rechercher" class="submit" name="recher">
      </form>
     
      <form action="" method="post">
        <input type="submit" value="Déconnexion" class="submit" name="déco">
      </form>
      <?php
      $deco=$_POST["déco"] ?? "";
      if($deco){
        session_destroy();
        header('location:connexion.php');
      };
      ?>

<?php
        $mot=$_POST["search"] ?? "";
        $recher=$_POST["recher"]??"";
        if($recher){
            $bdd = new PDO('mysql:host=127.0.0.1;dbname=sio1_tp5','root','');
            $sql = $bdd->prepare("SELECT * from oeuvre where titre like :mot");
            $sql -> bindValue(":mot","%".$mot."%",PDO::PARAM_STR);
            $sql->execute();
            $result=$sql->fetchALL(PDO::FETCH_OBJ);
            if($result){
                $nb=count($result);
                echo "Nombre de résultat:".$nb."<br><br><br>";
                for($i=0;$i<$nb;$i++){
                    $nom=$result[$i]->titre;
                    $ext=$result[$i]->auteur;
                    $ect=$result[$i]->nb_exemplaires;
                    echo $nom." ".$ext." " .$ect."<br><br>";
                }
            }
        }
      ?>
</div>

