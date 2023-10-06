$mostRecentBackup = (get-childitem . "202*.sql" | sort -Descending {$_.LastWriteTime} | select -first 1).fullname
Write-Host "Restoring creating new postgres container from $mostRecentBackup dump."
$volumeMap = $mostRecentBackup+":/docker-entrypoint-initdb.d/init.sql"
docker run -d --rm -e POSTGRES_PASSWORD=password -p 5432:5432 -v $volumeMap postgres