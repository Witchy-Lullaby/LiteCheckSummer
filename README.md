# LLM LiteHasher [CheckSummer]
[Console] Even more lite version of MD5 CheckSummer Hasher and comparer with custom settings. Version without UI that can compare and compute chekcsums into .txt file.<br></br>

> Version with UI [<a href="https://github.com/limelight-mint/MD5-CheckSummer">clickable</a>]: 
<br><a href="https://github.com/limelight-mint/MD5-CheckSummer"><img width="100" height="150" src="https://github.com/limelight-mint/MD5-CheckSummer/blob/main/examples/1.png"> <img width="100" height="150" src="https://github.com/limelight-mint/MD5-CheckSummer/blob/main/examples/2.png"> <img width="100" height="150" src="https://github.com/limelight-mint/MD5-CheckSummer/blob/main/examples/3.png"> </a></br>

<details>
<summary>[EN] How to use?</summary>
Run a build LLMCheckSummer.exe or Visual Studio project with arguments either '--compute' or '--compare', providing the path, filename and separator (for compare path1, path2)
The result will be either:<br></br>

> .txt document with all hashes named with the filename you passed and registry key with path
<br>--- AND ---</br>
> - Registry Key with result TRUE/FALSE for comparer [Registry/HKEY_CURRENT_USER/LLM in key COMPARE_HASH_ACTION_RESULT]
> - Registry Key with result of actual human readable text with the prompt for comparer [Registry/HKEY_CURRENT_USER/LLM in key COMPARE_HASH_ACTION_RESULT_READABLE]
> - Registry Key with result with all checksums in format FILE_NAME{your_separator(by default ':')}CHECKSUM [Registry/HKEY_CURRENT_USER/LLM in key COMPUTE_HASH_ACTION_RESULT]
> - Registry Key with result file that contains all checksums [Registry/HKEY_CURRENT_USER/LLM in key COMPUTE_HASH_ACTION_FILEPATH]

<br></br>
Examples:

To create file named checksum.txt with separator ':' you call arguments like that:
```
--compute C:\Users\Documents\GitHub\LiteHasher : checksum
```
By default CheckSummer gives u relative path (short paths, like /github/readme.md) to create file named checksum.txt with separator ':' AND store a full path to files you call arguments like that:
```
--compute C:\Users\Documents\GitHub\LiteHasher : checksum ++fullPath
```
To create checksums with separator ':' but without generating file (just result in the Registry):
```
--compute C:\Users\Documents\GitHub\LiteHasher :
```
Or to compare already compiled 2 files with different separators ':' and '♡♡♡♡' for example, it would be like that:
```
--compare C:\Users\Documents\GitHub\LiteHasher\checksum.txt D:\Apps\examples\checksum.txt : ♡♡♡♡ 
```

</details>

<details>
<summary>[RU] Как пользоваться?</summary>
Запустить билд или приложение в Visual Studio с аргументами '--compute' или '--compare', так же указав путь, имя файла, и разделитель (для --compare нужно 2 пути, первого и второго файла через пробел)
Результат:<br></br>

> .txt текстовый документ со всеми хеш-суммами в файле с названием который вы указали третьим аргументом после пути
<br>--- И ---</br>
> - Ключ в реестре со значением TRUE/FALSE если используете сравнение [Редактор Реестра/HKEY_CURRENT_USER/LLM в ключе который называется COMPARE_HASH_ACTION_RESULT]
> - Ключ в реестре с текстом результата понятным для пользователя если используете сравнение [Редактор Реестра/HKEY_CURRENT_USER/LLM в ключе который называется COMPARE_HASH_ACTION_RESULT_READABLE]
> - Ключ в реестре со всеми чек-суммами в формате ИМЯ_ФАЙЛА{ваш разделитель(по умолчанию ':')}ЧЕК-СУММА если вы используете создание [Редактор Реестра/HKEY_CURRENT_USER/LLM в ключе который называется COMPUTE_HASH_ACTION_RESULT]
> - Ключ в реестре с полным путем где находится файлик с суммами если вы используете создание [Редактор Реестра/HKEY_CURRENT_USER/LLM в ключе который называется COMPUTE_HASH_ACTION_FILEPATH]

<br></br>
Примеры аргументов:

Для создания файла с именем checksum.txt и разделителем ':' можете передать такие аргументы:
```
--compute C:\Users\Documents\GitHub\LiteHasher : checksum
```
По умолчанию CheckSummer записывает короткие пути (что-то в духе /github/readme.md) для создания файла checksum.txt с разделителем ':' но при этом сохраняя полные пути к файлам - мы просто дописываем ++fullPath:
```
--compute C:\Users\Documents\GitHub\LiteHasher : checksum ++fullPath
```
Для создания хеш-сумм без файла (только ключ в реестре) и разделителем ':' не нужно передавать имя файла:
```
--compute C:\Users\Documents\GitHub\LiteHasher :
```
Или же для сравнения двух уже скомпилированных файлов с хеш-суммами но например разными разьеденителями ':' и '♡♡♡♡' это будет выглядеть вот так:
```
--compare C:\Users\Documents\GitHub\LiteHasher\checksum.txt D:\Apps\examples\checksum.txt : ♡♡♡♡ 
```

</details>
<br></br>
<details>
<summary>i dont get it</summary>
The same app but with User Interface (buttons and images, u tiktok kids) is located here: (its easier)
https://github.com/limelight-mint/MD5-CheckSummer
</details>

<br>
### Disclaimer: DataMaintainer.cs using `Registry.Get/SetValue` which is not cross-platform, if u seek a cross-platform move, just edit those lines. PRs are welcome but must have descriptions of what problem they resolve.
