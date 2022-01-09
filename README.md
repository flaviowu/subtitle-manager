# subtitle-manager

Uma biblioteca para manipular arquivos de legenda formato SubRip (*.srt) em C#

### Classe SrtIO:
Método ReadSrt retorna uma string a partir de um arquivo no formato SubRip (*.srt). Seve ser informado o path completo para o arquivo.
Método WriteSrt escreve um arquivo no armazenamento local a partir de uma array gerada pelo método Parse da Classe Subtitles. Deve ser passado a array e o nome do arquivo a ser gerado.

### Classe Subtitles:
Método Parse retorna uma ArrayList de SubtitleBlocks a partir da string gerada a partir de um arquivo no formato SubRip. Deve se passar apenas a string.
Método Offset retorna uma ArrayList de SubtitleBlocks com o tempo inicial e final da legenda deslocados a fim de sincronizar com o vídeo. É preciso informar o ArrayList retornado pelo método Parse da mesma classe e o tempo de deslocamento em segundos (é usado tipo double).

### Classe SubtitleBlocks:
É um objeto que será instanciado contendo os campos:
1. BlockNumber: número do bloco de legendas;
2. StartTime: tempo de início do segmento das legendas;
3. EndTime: tempo final do segmento das legendas;
4. Textcontent: conteúdo das legendas.

O método ToString() foi sobrescrito para devolver os blocos de legenda no formato SubRip.

