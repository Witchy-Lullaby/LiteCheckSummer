# LLM LiteHasher [CheckSummer]
[Console] Even more lite version of MD5 CheckSummer Hasher and comparer with custom settings. Version without UI that can compare and compute chekcsums into .txt file.<br></br>

> Version with UI [<a href="https://github.com/limelight-mint/MD5-CheckSummer">clickable</a>]: 
<br><a href="https://github.com/limelight-mint/MD5-CheckSummer"><img width="100" height="150" src="https://github.com/limelight-mint/MD5-CheckSummer/blob/main/examples/1.png"> <img width="100" height="150" src="https://github.com/limelight-mint/MD5-CheckSummer/blob/main/examples/2.png"> <img width="100" height="150" src="https://github.com/limelight-mint/MD5-CheckSummer/blob/main/examples/3.png"> </a></br>

<details>
<summary>[EN] How to use?</summary>
Run a build or Visual Studio project with arguments either '--compute' or '--compare', providing the path, filename and separator (for compare path1, path2)
The result will be either:<br></br>

> .txt document with all hashes named with the filename you passed and registry key with path
<br>--- OR ---</br>
> Registry Key with result TRUE/FALSE for comparer [Registry/HKEY_CURRENT_USER/LLM in key COMPARE_HASH_ACTION_RESULT]

<br></br>
Examples:

To create file named checksum.txt with separator ':' you call arguments like that:
```
--compute C:\Users\user\Documents\GitHub\LiteHasher checksum :
```
Or to compare already compiled 2 files with different separators ':' and '♡♡♡♡' for example, it would be like that:
```
--compare C:\Users\user\Documents\GitHub\LiteHasher\checksum.txt D:\Apps\examples\checksum.txt : ♡♡♡♡ 
```

</details>

<details>
<summary>[RU] Как пользоваться?</summary>
Запустить билд или приложение в Visual Studio с аргументами '--compute' или '--compare', так же указав путь, имя файла, и разделитель (для --compare нужно 2 пути, первого и второго файла через пробел)
Результат:<br></br>

> .txt текстовый документ со всеми хеш-суммами в файле с названием который вы указали третьим аргументом после пути
<br>--- ИЛИ ЖЕ ---</br>
> Ключ в реестре со значением TRUE/FALSE если используете сравнение [лежит в Редактор Реестра/HKEY_CURRENT_USER/LLM в ключе который называется COMPARE_HASH_ACTION_RESULT]

<br></br>
Примеры аргументов:

Для создания файла с именем checksum.txt и разделителем ':' можете передать такие аргументы:
```
--compute C:\Users\user\Documents\GitHub\LiteHasher checksum :
```
Или же для сравнения двух уже скомпилированных файлов с хеш-суммами но например разными разьеденителями ':' и '♡♡♡♡' это будет выглядеть вот так:
```
--compare C:\Users\user\Documents\GitHub\LiteHasher\checksum.txt D:\Apps\examples\checksum.txt : ♡♡♡♡ 
```

</details>
<br></br>
<details>
<summary>i dont get it</summary>
The same app but with User Interface (buttons and images, u tiktok kids) is located here: (its easier)
https://github.com/limelight-mint/MD5-CheckSummer
</details>
