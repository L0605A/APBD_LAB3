using System;
using APBD_LAB3;
using APBD_LAB3.Enums;

Flagship bebop = new Flagship(0);
Flagship swordfishII = new Flagship(1);

ContainerManager.addGasContainer(100,100,100,90,10);
ContainerManager.addGasContainer(100,100,100,90,10);
ContainerManager.addGasContainer(100,100,100,90,10);
Container toDelete = ContainerManager.addGasContainer(100,100,100,90,10);

ContainerManager.addLiquidContainer(100,100,100,90,true);
ContainerManager.addLiquidContainer(100,100,100,90,false);

Container container = ContainerManager.addRefrigiratedContainer(100,100,100,90,Products.Bananas, 10);

bebop.loadContainer(ContainerManager.ContainerList);

bebop.printManifest();

bebop.moveContainer(toDelete, swordfishII);

bebop.printManifest();
swordfishII.printManifest();

swordfishII.unloadContainer(toDelete);

swordfishII.printManifest();

toDelete.Load(50);

swordfishII.loadContainer(toDelete);

toDelete.Unload();

container.Load(10);

swordfishII.replaceContainer(toDelete,container);

container.PrintData();