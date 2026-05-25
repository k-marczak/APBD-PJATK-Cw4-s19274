# APBD web api

## Opis projektu

REST API do zarządzania komputerami oraz komponentami. 

Aplikacja została wykonana w ASP.NET Core Web API z użyciem Entity Framework Core w podejściu Code First. 

---

## Struktura projektu

- `Models` - klasy encji mapowane na tabele w bazie danych
- `Data` - kontekst bazy danych oraz konfiguracja relacji
- `DTOs` - obiekty używane do komunikacji przez API
- `Controllers` - endpointy REST API
- `Migrations` - migracje Entity Framework Core

## Baza danych

Projekt korzysta z SQL Server LocalDB.

## Uruchomienie aplikacji 

dotnet run

## Swagger

http://localhost:PORT/swagger

## Endpointy

GET /api/pcs

GET /api/pcs/{id}/components

POST /api/pcs

PUT /api/pcs/{id}

DELETE /api/pcs/{id}
