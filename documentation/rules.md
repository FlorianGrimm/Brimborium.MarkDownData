# Rules - Brimborium.MarkDownData

The rules for MarkDownData.

- You know which schema is addressed.

## Round Trip

- One round trip should be possible - but not on all costs.

mdd-text0 ----> data ---> mdd-text1

- Two round trips must create the same md content.

mdd-text0 ----> data ---> mdd-text1  ----> data ---> mdd-text1 

e.g. if a normalizing/beautifing happens this should result in the same text if you run it twice.

## Extraction

The extraction should not fail if the content is bongus.
The extraction must know which schema is addressed.
Everything that does not fit is trivia.

## Generation

If their are more than one way to express the data as markdown

- use the one that the round trip defines.
- use the fallback (however this is defined)