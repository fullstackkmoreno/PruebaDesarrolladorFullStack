# PruebaDesarrolladorFullStack

# Pasos para ejecutar prueba

- get the two projects from repository back-end and front-end
- service localhost: go to folder from back-end and open project at visual studio
- now go menu build/ build solution
- now go menu debug/debug solution
- service http://www.PruebaDesarrolloFullStack.somee.com: 
- POST: http://www.PruebaDesarrolloFullStack.somee.com/BaseEspacial
BODY:
[
  {
    "nombre": "kenobi",
    "distancia": 100.0,
    "mensaje": [
      "este", "", "", "mensaje", ""
    ]
  },
  {
    "nombre": "skywalker",
    "distancia": 115.5,
    "mensaje": [
      "", "es", "", "", "secreto"
    ]
  },
  {
    "nombre": "sato",
    "distancia": 142.7,
    "mensaje": [
      "este", "", "un", "", ""
    ]
  }
]
GET: http://www.PruebaDesarrolloFullStack.somee.com/BaseEspacial/Kenobi
POST: http://www.PruebaDesarrolloFullStack.somee.com/BaseEspacial/Kenobi
BODY:
  {
    "nombre": "kenobi",
    "distancia": 100.0,
    "mensaje": [
      "este", "", "", "mensaje", ""
    ]
  }
- open window powershell and write commands next:
 cd folder from front-end eg: D:\PruebaTecnica\front-end
 code .
- go servicio.service.ts actualizar environment loscalhost o prod
- now go to menu Terminal/new Terminal and execute the command next:
 ng serve -o


