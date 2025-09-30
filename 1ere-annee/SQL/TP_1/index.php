<html>
<head>
<title>PHP / MySQL: PDO</title>
<meta charset="utf-8">
<link rel="stylesheet" href="styles.css">
</head>
<body>
    <div id="barre">
<h1>Liste des livres disponibles</h1>
</div>
<?php
$username = 'Admin';
$password = 'sio';
$pdo = new PDO("mysql:host=localhost;dbname=sio1_tp_affichage",
$username, $password);

$sql_liste_livres="SELECT * FROM oeuvre";
$liste_livres= $pdo->query($sql_liste_livres);

$result = $liste_livres->fetchAll(PDO::FETCH_OBJ);
echo '<table>';
for($n=0; $n < 13; $n++){
    echo"<tr>";
    echo"<td>";
    echo '<pre>';
    echo($result[$n]->idoeuvre);
    echo"</td>";
    echo"<td>";
    echo" &nbsp"."<a class='titre'>".($result[$n]->titre)."</a>";
    echo"</td>";
    echo"<td>";
    echo" &nbsp"."<a class='auteur'>".($result[$n]->auteur)."</a>";
    echo"</td>";
    echo"<td class='numéro'>";
    echo"<a class='numéro'>".($result[$n]->nb_exemplaires)."</a>";
    echo"</td>";
    echo"<td>";
    echo"<div class='im'><img src='".($result[$n]->Image)."'></div>";
    echo '</pre>';
    echo"</td>";
    echo "<td>";
    echo"<form method='post'> <input type='submit' value='Supprimer' name='del' id='".($result[$n]->idoeuvre)."'></form>";
    echo"</td>";
    echo"<tr>"; }
echo'</table>';


function del(){
    $oeuvre="13";
    $pdo = new PDO("mysql:host=localhost;dbname=sio1_tp_affichage","root", "");
    $del=$pdo->prepare("DELETE from oeuvre where idoeuvre=?");
    $del->execute(array($oeuvre));
}

if(isset($_POST["del"])){
    del();
}

?>
</body>