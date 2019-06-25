# testJokenpo run

dotnet build

dotnet run

http://localhost:7001/swagger/index.html

valid values: pedra=0, papel=1, tesoura=2, spock= 3, lagarto= 4

teste:
Tesoura corta papel
Papel cobre pedra
Pedra esmaga lagarto
Lagarto envenena Spock
Spock esmaga (ou derrete) tesoura
Tesoura decapita lagarto
Lagarto come papel
Papel refuta Spock
Spock vaporiza pedra
Pedra quebra tesoura

ex:
http://localhost:7001/api/Game/tesoura/papel
