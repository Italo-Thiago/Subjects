'''
Exercício 4: Reprodutor de Mídia
Descrição:
Crie classes para representar diferentes tipos de arquivos de mídia (ex: MP3, WAV, FLAC). Cada classe deve ter um método reproduzir() que exibe uma mensagem específica (ex: "Reproduzindo arquivo MP3..."). Use polimorfismo para criar uma função que recebe uma lista de arquivos e chama reproduzir() em cada um, independentemente do tipo.

O que implementar:

1. Classes MP3, WAV, FLAC, cada uma com o método reproduzir().
2. Uma função reproduzir_todos(arquivos) que itera sobre a lista e chama reproduzir() para cada objeto.
'''

class Media:
    def reproduce(self, format:str = ""):
        pass

class MP3(Media):
    def reproduce(self):
        print(f"\nPlaying file MP3 ...");

class WAV(Media):
    def reproduce(self):
        print(f"\nPlaying file WAV ...");

class FLAC(Media):
    def reproduce(self):
        print(f"\nPlaying file FLAC ...");

def play_all(formats:Media = []):
    for format in formats:
        format.reproduce();
    
mp3 = MP3();
wav = WAV();
flac = FLAC();

f = [mp3, wav, flac];

play_all(f);