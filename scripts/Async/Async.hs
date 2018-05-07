
getData :: IO Int
getData = return 100

getMoreData :: Int -> IO Int
getMoreData x = return $ x + 1

main :: IO ()
main = 
    getData >>= getMoreData >>= getMoreData >>= getMoreData >>= getMoreData >>= print


