Justice.cz data download

·        Public registry of czech economic subjects has an API to download XML/CSV data

·        We are interested in all current data for year 2022

·        Create a robot that will
<br>

o   download all "actual" data files for the year 2022

o   Parse the data file into a table with following columns (names of the source nodes are in brackets)

·        Name (<nazev>)

·        BusinessID (<ico>)

·        AddressCity (<adresa><obec>)

·        AddressStreet (<adresa><ulice>)

·        AddressStreetNr (<adresa><cisloPo>)

·        AddressHouseNr (<adresa><cisloOr>)

·        AddressZIP (<adresa><psc>)

·        LegalForm (<pravniForma><nazev>)

o   Save this table into an excel file

·        IMPORTANT

o   The data volume for full process would be enormous

o   Create full process logic, but disable the parts that would download all the packages

o   Additionally create an activity to download only one data package - nadf-actual-usti_nad_labem-2022

o   This is to see how the full process would look like and to be able to perform a test run at the same time

o   Parsing the data file can prove difficult in UiPath, so feel free to use any external method (VBA script, C#,…) if you choose to

 <br>

URLs

Data packages: https://dataor.justice.cz/api/3/action/package_list

Here you will have the ID list of all packages available
Single package info: https://dataor.justice.cz/api/3/action/package_show?id=[package-id]

Description of a single package
You can find the URL to the XML file (e.g.: "url":http://dataor.justice.cz/api/file/nadf-actual-usti_nad_labem-2022.xml)