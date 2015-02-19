NYCGeoClientGeoREST
===================
Since there are 6 underlying services that could be called, certain keys are required (basically taken right from the Geoclient API doc for each method).

Depending on which keys are present (name for PLACE searches, houseNumber for ADDRESS, bin for BIN, etc.) the wrappers routes to a different Geoclient URL.

Borough is required for Geoclient, but I just default to Manhattan if it isn’t specified for no particular reason.

PLACE
name:

ADDRESS
houseNumber: street:

BIN
bin:

BBL
Block: lot:

BLOCKFACE
onStreet: crossStreetOne: crossStreetTwo:
(no lat lon for blockface>) so no result in map viewers

INTERSECTION
crossStreetOne: crossStreetTwo:

Examples:

PLACE
name:statue of liberty

ADDRESS
houseNumber: 314 street:west 100 st

BIN
bin:1079043

BBL
Block:1889 lot:1

BLOCKFACE
onStreet:amsterdam ave crossStreetOne:w 110 st crossStreetTwo:w 111 st

INTERSECTION
crossStreetOne:broadway crossStreetTwo:w 99 st
