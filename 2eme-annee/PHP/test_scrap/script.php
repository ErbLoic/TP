<?php
require 'vendor/autoload.php';
use Goutte\Client;
use Symfony\Component\HttpClient\HttpClient;
use PhpOffice\PhpSpreadsheet\Spreadsheet;
use PhpOffice\PhpSpreadsheet\Writer\Xlsx;

$httpClient=HttpClient::create(['proxy'=>'http://lerbuer:Mai140323.@192.168.100.55:3128',]);

$client = new Client($httpClient);


$crawler = $client->request('GET', 'https://www.medicament.com/14-medicaments/');

$categories = [];

$crawler->filter('#categories_block_left .block_content a')->each(function ($node) use (&$categories) {
    $categoryName = trim($node->text());
    $categoryLink = $node->attr('href');

    $lastPart = basename(parse_url($categoryLink, PHP_URL_PATH));
    $parts = explode('-', $lastPart);
    $categoryId = (int) $parts[0];

    $categories[] = [
        'id'   => $categoryId,
        'name' => $categoryName,
        'url'  => $categoryLink,
    ];
});


$cat_products = [];



foreach ($categories as $cat) {
    $crawler = $client->request('GET', $cat['url']);

    $crawler->filter('.product-container')->each(function ($node) use (&$cat_products, $cat) {
        $name = trim($node->filter('h5[itemprop="name"] a')->text());
        $price = $node->filter('span.price')->count() ? trim($node->filter('span.price')->text()) : '';
        $image_url = $node->filter('img')->attr('src');
        $description = trim($node->filter('p.product-desc')->text());

        $cat_products[] = [
            'cat_id'    => $cat['id'],
            'cat_name'  => $cat['name'],
            'prod_name' => $name,
            'price'     => $price,
            'image_url' => $image_url,
            'description' => $description,
        ];
    });
    sleep(1);
}



$spreadsheet = new Spreadsheet();
$sheet = $spreadsheet->getActiveSheet();
$sheet->setTitle('Medicaments');
$sheet->setCellValue('A1', 'Catégorie ID');
$sheet->setCellValue('B1', 'Produit Nom');
$sheet->setCellValue('C1', 'Prix');
$sheet->setCellValue('D1', 'Image URL');
$sheet->setCellValue('E1', 'Description');

$row = 2;
foreach ($cat_products as $prod) {
    $sheet->setCellValue('A' . $row, $prod['cat_id']);
    $sheet->setCellValue('B' . $row, $prod['prod_name']);
    $sheet->setCellValue('C' . $row, $prod['price']);
    $sheet->setCellValue('D' . $row, $prod['image_url']);
    $sheet->setCellValue('E' . $row, $prod['description']);
    $row++;
}

$writer = new Xlsx($spreadsheet);
$writer->save('medicaments.xlsx');
echo "Données extraites et enregistrées dans medicaments.xlsx\n";


$spreadsheet2 = new Spreadsheet(); 
$sheet2 = $spreadsheet2->getActiveSheet();
$sheet2->setTitle('Catégories');
$sheet2->setCellValue('A1', 'ID');
$sheet2->setCellValue('B1', 'Nom');

$row = 2;
foreach ($categories as $cat) {
    $sheet2->setCellValue('A' . $row, $cat['id']);
    $sheet2->setCellValue('B' . $row, $cat['name']);
    $row++;
}

$writer2 = new Xlsx($spreadsheet2); 
$writer2->save('categories.xlsx');
echo "Catégories extraites et enregistrées dans categories.xlsx\n";
