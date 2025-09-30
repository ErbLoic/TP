<html>
    <head>
        <title>Inscription</title>
        <meta charset="utf-8">
        <link href="style.css" rel="stylesheet" >
    </head>
    <body>    
    <div class="form2">
      <div class="title">Bienvenue</div>
      <div class="subtitle">Connectez-vous</div>
      <div class="input-container ic1">
      <form action="" method="post">
      <div class="input-container ic2">
        <input id="pseudo" name="pseudo" class="input" type="text" placeholder=" " required />
        <div class="cut cut-short"></div>
        <label for="pseudo" class="placeholder">Pseudo</label>
      </div>
      <div class="input-container ic2">
        <input id="mdp" name="mdp" class="input" type="password" placeholder=" " required />
        <div class="cut cut-short"></div>
        <label for="mdp" class="placeholder">Mot de passe</label>
      </div>
      </div>
      <input type="submit" id="envoyer2" name="Connexion" value="Se connecter" type="text" class="submit">
      </form>
      <form action="inscription.php">
        <input type="submit" name="envoyer" value="Inscription" type="text" class="submit">
        <?php 
        session_start();
        $inscription_ok_bis=$_SESSION["inscription_ok"]?? "";
        if($inscription_ok_bis=="oui"){
          echo "<div class='subtitle'>Inscription validée.</div>";
        }
        ?>
</form>
    </div>
    </div>

    <?php
    $connexion=$_POST["Connexion"] ?? "";
    $pseudo=$_POST["pseudo"] ?? "";
    $mdp1=$_POST["mdp"] ?? "";
    if($connexion){
      $bdd= new PDO('mysql:host=127.0.0.1;dbname=test','root','');
      $sql = $bdd -> prepare("SELECT * FROM client where pseudo=?");
      $sql -> execute(array($pseudo));
      $client = $sql-> fetchALL(PDO::FETCH_OBJ);
      if($client){
        $mdp_bdd=$client[0]->mdp;
        if(password_verify($mdp,$mdp_bdd)){
          $_SESSION["Autoriser"]='non';
          $_SESSION["pseudo"]=$pseudo;
          header('location:acceuil.php');
        }
        else{
          session_destroy();
          header("location:connexion.php");
        }
      }
    }

    ?>