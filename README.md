# ACOS Kick-Off Utviklerspor - .NetCore og ASP.NetCore

Dotnet Core presentasjon på Kick-Off 2017. Gjennomgang og demo av hvordan man setter opp en fungerende REST-API med DotNet Core.

Presentasjon av [Teis Lindemark](mailto:teis@acos.no) og [Kjartan](mailto:kjartan@acos.no).

Presentasjonen er tilgjengelig på [Github]().

## Versjoner (to hovedspor)

* **1.0 - Long Term**

Ble lansert i juni 2016 med RTM release etter en lengere utvikling og flere faser med beta og release kandidater.

* **1.1 - Current**

Mulig å også kjøre på nattlige bygginger ved å sette opp NuGet.config til Microsoft ASP.Net myget feed, [myget feed]()

Tilbake til .csproj fil fra [**.NET Core SDK 1.0 Preview 4 build 004233**](https://github.com/dotnet/core/blob/master/release-notes/preview4-download.md).

Tilbake fra project.json til til csproj prosjektfil. .NetCore sin csproj har endel forbedringer i forhold til hvordan csproj filen har vært i .Net tidligere. Prosjektfilen støtter nå wildcard så det vil ikke være nødvennig å liste opp alle filene som tidligere.

## Hva er nytt fra standard .Net?

.NetStandard versjoner og kompabilitet med klassisk .Net framework. Tabellen er hentet fra [CoreFx]() på Github.

 | 1.0 | 1.1 | 1.3 | 1.4 | 1.5 | 1.6 | 2.0
 --- | --- | --- | --- | --- | --- | --- | ---
 ... | | | | | | | 

* Alt er NuGet-pakker
* .NetStandard skal erstatte dagens PCL.
* ASP.Net Core er en konsollapplikasjon.

## Middleware

* Pipelinen konfigureres i Startup.cs
* **"Alt"** er middelware i dotnet core. Middelware er også NuGet pakker. Det gjør det enkelt å ikke ta med mer enn man faktisk trenger i prosjektet.
* YSOD (Yellow Screen of Death) er ikke default i .Net Core.
* Alle request går igjennom middelware pipelinen.

## Verktøy

Mange gode alternativer i Visual Studio serien.

 | Visual Studio IDE | Visual Studio Code | Visual Studio Mac | ff
--- | --- | --- | --- | ---
Plattform | Windows | Windows/Linux/MacOS | MacOS | Windows/Linux/MacOS
Brukervennlighet | 2 | 3 | 4 | 5
... | 2 | 3 | 4 | 5
Pris | Gjennom Visual Studio Subscription | **Gratis (Open Source)** | Gjennom Visual Studio Subscription | 5

* [Visual Studio Toolingen i preview](https://www.visualstudio.com/vs/)

Den samme Visual Studio opplevelsen som man er vandt til fra tidligere versjoner av .Net.

* [Visual Studio Code](https://code.visualstudio.com)

Visual Studio Code er en teksteditor utviklet med [Electron]() rammeverket. En editor som er veldig lett å bygge på med utvidelser. Utvidelser som omnisharp, c# og mssql er et must og gjør opplevelsen veldig bra. Full debug support.

* [Visual Studio for Mac](https://www.visualstudio.com/vs/visual-studio-mac/)

Visual Studio for Mac er et resulat av at Microsoft kjøpte opp Xamarin. Har man brukt Xamarin Studio så er Visual Studio for Mac veldig kjent.

* [XXX]()

En ny C# IDE for .Net Core fra selskapet bak IntelliJ og ReSharper.

## Demo

* [Request pipeline og middleware](./Demo//src/BasicDemo/README.md)
* [Custom middelware](./Demo/src/MiddelwareDemo/README.md)
* [Routing](./Demo/src/RoutingDemo/README.md)
* [Dependency Injection](./Demo/src/DIDemo/README.md)

Hvis tid temaer til demoen

* API dokumentasjon (Swagger)

## Gratis kurs og annet materiale

* [Introduksjonskurs DotNet Core](http://bit.ly/2gWxr2Y), http://bit.ly/2gWxr2Y
* [Intermidiate DotNet Core](http://bit.ly/2hCEvWl), http://bit.ly/2hCEvWl
* [ASP.Net Ukentlige Standup](http://live.asp.net)
* [Microsoft ASP.Net team blog](). Her legges det ut linker til bloggposter som blir dratt frem på den ukentlige standupen og mye annen informasjon.
* [ASP.Net dokumentasjon](http://docs.asp.net/)
* [.Net Core dokumentasjon]()