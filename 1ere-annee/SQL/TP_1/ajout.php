<html>
<head>
<title>PHP / MySQL: PDO</title>
<meta charset="utf-8">
<link rel="stylesheet" href="styles.css">
</head>
<body>
    <div id="barre">
<h1>Insertion d'oeuvre</h1>
</div>
<Form action="" method="post">
    <input type="text" name="titre" placeholder="Titre*" id="titre"><br>
    <input type="text" name="auteur" placeholder="Auteur*" id="auteur"><br>
    <input type="number" name="nb_exemplaire" placeholder="Nombre d'exemplaire*" id="nb_exemplaire"><br>
    <input type="file" name="image" placeholder="Image*" id="image"><br>
    <input type="submit" value="Ajouter" name="inscription"><br>
</form>
</html>

<?php
function inscription(){
    $titre=$_POST["titre"] ?? "";
    $auteur=$_POST["auteur"] ?? "";
    $nb_exemplaire=$_POST["nb_exemplaire"] ?? "";
    $image="Images/".$_POST["image"] ?? "";
    $username = 'root';
    $password = '';
    $pdo = new PDO("mysql:host=localhost;dbname=sio1_tp_affichage",$username, $password);
    $insert= $pdo->prepare("INSERT INTO oeuvre VALUES(?,?,?,?,?)");
    $insert->execute(array("",$titre,$auteur,$nb_exemplaire,$image));
}

inscription()
?>
