<?php

function getPDO() {
    return new PDO("mysql:host=localhost;dbname=bibliotheque", "root", "");
}

function getNbEmpruntsAdherent($idAdherent) {
    $pdo = getPDO();
    $stmt = $pdo->prepare("CALL pNbEmpruntsAdherent(:id, @res)");
    $stmt->bindParam(':id', $idAdherent, PDO::PARAM_INT);
    $stmt->execute();
    $res = $pdo->query("SELECT @res AS nbEmprunts")->fetch();
    return $res['nbEmprunts'];
}

function getStatutLivre($idLivre) {
    $pdo = getPDO();
    $stmt = $pdo->prepare("CALL pStatutLivre(:id, @res)");
    $stmt->bindParam(':id', $idLivre, PDO::PARAM_INT);
    $stmt->execute();
    $res = $pdo->query("SELECT @res AS statut")->fetch();
    return $res['statut'];
}

function getRetardEmprunts() {
    $pdo = getPDO();
    $stmt = $pdo->prepare("CALL pRetardEmprunts()");
    $stmt->execute();
    $res = [];
    do {
        $rows = $stmt->fetchAll();
        if ($rows) $res = array_merge($res, $rows);
    } while ($stmt->nextRowset());
    return $res;
}

function sanctionnerAdherent() {
    $pdo = getPDO();
    $stmt = $pdo->prepare("CALL pSanctionsAdherents()");
    $stmt->execute();
    $messages = [];
    do {
        $result = $stmt->fetchAll();
        if ($result) {
            foreach ($result as $row) {
                $messages[] = $row['Message'];
            }
        }
    } while ($stmt->nextRowset());
    return $messages;
}

$idAdherent = 2;
$idLivre = 3;
$retards = getRetardEmprunts();
$sanctions = sanctionnerAdherent();

?>

<!DOCTYPE html>
<html lang="fr">
<head>
<meta charset="UTF-8">
<title>Bibliothèque - Test Procédures</title>
<style>
    body { font-family: Arial, sans-serif; background-color: #f5f5f5; margin: 20px; }
    h2, h3 { color: #333; }
    table { border-collapse: collapse; width: 100%; background-color: #fff; box-shadow: 0 0 10px rgba(0,0,0,0.1); }
    th, td { padding: 10px; text-align: center; border-bottom: 1px solid #ddd; }
    th { background-color: #4CAF50; color: white; cursor: pointer; }
    tr:nth-child(even) { background-color: #f9f9f9; }
    tr:hover { background-color: #f1f1f1; }
    .container { max-width: 800px; margin: auto; }
    .button { padding: 8px 15px; background-color: #4CAF50; color: white; border: none; cursor: pointer; margin: 10px 0; border-radius: 5px; }
    .button:hover { background-color: #45a049; }
</style>
</head>
<body>
<div class="container">
    <h2>Test Procédures Stockées</h2>

    <p><strong>Nombre d'emprunts pour l'adhérent <?= $idAdherent ?> :</strong> <?= $idAdherent ? getNbEmpruntsAdherent($idAdherent) : 0 ?></p>
    <p><strong>Statut du livre <?= $idLivre ?> :</strong> <?= getStatutLivre($idLivre) ?></p>

    <h3>Liste des emprunts en retard</h3>
    <button class="button" onclick="sortTable()">Trier par jours de retard</button>
    <?php if (!empty($retards)): ?>
    <table id="retardsTable">
        <thead>
            <tr>
                <th>Id Emprunt</th>
                <th>Jours de Retard</th>
            </tr>
        </thead>
        <tbody>
            <?php foreach ($retards as $retard): ?>
            <tr>
                <td><?= htmlspecialchars($retard['idEmprunt']) ?></td>
                <td><?= htmlspecialchars($retard['nbJoursRetard']) ?></td>
            </tr>
            <?php endforeach; ?>
        </tbody>
    </table>
    <?php else: ?>
        <p>Aucun emprunt en retard.</p>
    <?php endif; ?>

    <h3>Sanctions des adhérents</h3>
    <?php if (!empty($sanctions)): ?>
        <ul>
        <?php foreach ($sanctions as $message): ?>
            <li><?= htmlspecialchars($message) ?></li>
        <?php endforeach; ?>
        </ul>
    <?php else: ?>
        <p>Aucune sanction.</p>
    <?php endif; ?>
</div>

<script>
// Fonction pour trier le tableau par jours de retard
function sortTable() {
    let table = document.getElementById("retardsTable");
    let rows = Array.from(table.rows).slice(1); // ignore header
    rows.sort((a, b) => parseInt(b.cells[1].innerText) - parseInt(a.cells[1].innerText));
    rows.forEach(row => table.tBodies[0].appendChild(row));
}
</script>
</body>
</html>
