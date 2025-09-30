<html>
    <head>
        <title>Inscription</title>
        <meta charset="utf-8">
        <link href="style.css" rel="stylesheet" >
    </head>
    <body>    
    <div class="form">
      <div class="title">Bienvenue</div>
      <div class="subtitle">Créer votre compte</div>
      <div class="input-container ic1">
      <form action="inscription.php" method="post">
        <input id="nom" name="nom" class="input" type="text" placeholder=" " required />
        <div class="cut"></div>
        <label for="nom" class="placeholder">Nom</label>
      </div>
      <div class="input-container ic2">
        <input id="prenom" name="prenom" class="input" type="text" placeholder=" " required />
        <div class="cut"></div>
        <label for="prenom" class="placeholder">Prénom</label>
      </div>
      <div class="input-container ic2">
        <input id="pseudo" name="pseudo" class="input" type="text" placeholder=" " required />
        <div class="cut cut-short"></div>
        <label for="pseudo" class="placeholder">Pseudo</label>
      </div>
      <div class="input-container ic2">
        <input id="email" name="email" class="input" type="text" placeholder=" " required />
        <div class="cut cut-short"></div>
        <label for="email" class="placeholder">Email</label>
      </div>
      <div class="input-container ic2">
        <input id="mdp" name="mdp" class="input" type="password" placeholder=" " required />
        <div class="cut cut-short"></div>
        <label for="mdp" class="placeholder">Mot de passe</label>
      </div>
      <div class="input-container ic2">
        <input id="mdp2" name="mdp2" class="input" type="password" placeholder=" " required />
        <div class="cut cut-short"></div>
        <label for="mdp2" class="placeholder">Retaper votre mot de passe</label>
      </div>
      <a href="connexion.php">J'ai déjà un compte</a>
      <input type="submit" id="envoyer" name="envoyer" value="Envoyer" type="text" class="submit">
      </form>
    </div>

    <?php
    session_start();
    $envoyer=$_POST["envoyer"] ?? "";
    $nom=$_POST["nom"] ?? "";
    $prenom=$_POST["prenom"] ?? "";
    $pseudo=$_POST["pseudo"] ?? "";
    $email=$_POST["email"] ?? "";
    $mdp1=$_POST["mdp1"] ?? "";
    $mdp2=$_POST["mdp2"] ?? "";

    $mdpH=password_hash($mdp1,PASSWORD_BCRYPT);
    if($envoyer){
      $bdd= new PDO('mysql:host=127.0.0.1;dbname=test','root','');
      $insert= $bdd -> prepare("INSERT INTO client VALUES(?,?,?,?,?,?,?)");
      $insert->execute(array("",$nom,$prenom,$pseudo,$email,$mdpH,date("Y-m-d:m-m-s")));
      //echo"<script> alert('Inscription Valide');</script>";
      $_SESSION["inscription_ok"]='oui';
      header("location:connexion.php");//redirection
    }
    ?>