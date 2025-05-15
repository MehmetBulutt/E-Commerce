  function App() {
  return (
    <>
      <Header /> 
      <ProductList />
    </>
  )
}

function Header (){
  return(
    <div>
   <h1>Header</h1>
   <Product />
   </div>
  );
}

function ProductList (){
  return(
    <h2>ProductList</h2>
  );
}

function Product (){
  return(
    <h3>Product</h3>
  );
}

export default App
