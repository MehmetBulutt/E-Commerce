import { useEffect, useState } from "react";
import { IProduct } from "../../model/IProduct";
import ProductList from "./ProductList";
import { CircularProgress } from "@mui/material";
import request from "../../api/requests";

export default function CatalogPage() {
      const [products, setProducts] = useState<IProduct[]>([]);
      const [loading, setLoading] = useState(true);
    
      useEffect(() => {
       request.Catalog.list()
      .then(data => setProducts(data))
      .finally(() =>setLoading(false));

      }, []);

       if(loading) return <CircularProgress />
      
    return (
        <ProductList products={products} />
    );
}